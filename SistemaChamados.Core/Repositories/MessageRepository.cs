using Microsoft.Data.SqlClient;
using SistemaChamados.Core.Data;
using SistemaChamados.Core.Models;
using SistemaChamados.Core.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaChamados.Core.Repositories
{
    public class MessageRepository
    {
        // Repositório auxiliar, caso precise acessar informações dos chamados.
        private readonly TicketRepository _ticketRepository = new();

        // Retorna todas as mensagens associadas a um chamado específico.
        public List<Message> GetMessagesByTicketId(int chamadoId)
        {
            var messages = new List<Message>();
            using var conn = Database.GetConnection();
            conn.Open();

            // Consulta SQL que obtém o histórico de mensagens, incluindo nome e CRUD do usuário.
            string sql = @"
    SELECT h.HistoricoID, h.ChamadoID, h.UsuarioID, u.Nome AS UsuarioNome, u.CRUDID, 
           h.Mensagem, h.DataRegistro, h.IsSolution, h.SolutionPendingApproval
    FROM HISTORICOCHAMADO h
    INNER JOIN USUARIO u ON h.UsuarioID = u.UsuarioID
    WHERE h.ChamadoID = @ChamadoID
    ORDER BY h.DataRegistro ASC";

            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ChamadoID", chamadoId);
    
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                messages.Add(new Message
                {
                    HistoricoID = (int)reader["HistoricoID"],
                    ChamadoID = (int)reader["ChamadoID"],
                    UsuarioID = (int)reader["UsuarioID"],
                    UsuarioNome = reader["UsuarioNome"].ToString(),
                    CRUDID = reader["CRUDID"].ToString(),
                    Mensagem = reader["Mensagem"].ToString(),
                    DataRegistro = (DateTime)reader["DataRegistro"],
                    IsSolution = reader["IsSolution"] != DBNull.Value && (bool)reader["IsSolution"], // Verifica se há valores nulos antes de converter booleanos
                    SolutionPendingApproval = reader["SolutionPendingApproval"] != DBNull.Value && (bool)reader["SolutionPendingApproval"]
                });
            }

            return messages;
        }
        // Adiciona uma nova mensagem ao histórico de um chamado.
        // Caso seja uma solução, atualiza o status do chamado.
        public void AddMessage(Message message)
        {
            using var conn = Database.GetConnection();
            conn.Open();
            using var tran = conn.BeginTransaction();

            try
            {
                if (message.IsSolution)
                {
                    // Se for uma mensagem marcada como solução,
                    // remove o status de solução de mensagens anteriores do mesmo chamado.
                    var resetCmd = new SqlCommand(
                        "UPDATE HISTORICOCHAMADO SET IsSolution = 0 WHERE ChamadoID = @ChamadoID",
                        conn, tran);
                    resetCmd.Parameters.AddWithValue("@ChamadoID", message.ChamadoID);
                    resetCmd.ExecuteNonQuery();
                }

                // Insere uma nova entrada no histórico do chamado.
                var insertCmd = new SqlCommand(@"
            INSERT INTO HISTORICOCHAMADO
            (ChamadoID, UsuarioID, Mensagem, DataRegistro, IsSolution, SolutionPendingApproval)
            VALUES (@ChamadoID, @UsuarioID, @Mensagem, GETDATE(), @IsSolution, @Pending)", conn, tran);
                insertCmd.Parameters.AddWithValue("@ChamadoID", message.ChamadoID);
                insertCmd.Parameters.AddWithValue("@UsuarioID", message.UsuarioID);
                insertCmd.Parameters.AddWithValue("@Mensagem", message.Mensagem);
                insertCmd.Parameters.AddWithValue("@IsSolution", message.IsSolution);
                insertCmd.Parameters.AddWithValue("@Pending", message.IsSolution);
                insertCmd.ExecuteNonQuery();

                // Caso seja uma solução, altera o status do chamado.
                if (message.IsSolution)
                {
                    var updateTicket = new SqlCommand(
                        "UPDATE CHAMADO SET Status = 'Aguardando Aprovação' WHERE ChamadoID = @ChamadoID",
                        conn, tran);
                    updateTicket.Parameters.AddWithValue("@ChamadoID", message.ChamadoID);
                    updateTicket.ExecuteNonQuery();
                }
                // Confirma as alterações no banco de dados.
                tran.Commit();
            }
            catch
            {
                // Em caso de erro, desfaz todas as alterações pendentes.
                tran.Rollback();
                throw;
            }
        }
        // Adiciona uma nova mensagem marcada como solução, com verificação para evitar duplicidade.
        public bool AddSolutionMessage(Message message)
        {
            using var conn = Database.GetConnection();
            conn.Open();
            using var tran = conn.BeginTransaction();

            try
            {
                // Verifica se já existe uma solução registrada para o chamado.
                string checkSql = @"SELECT COUNT(*) FROM HISTORICOCHAMADO WHERE ChamadoID = @ChamadoID AND IsSolution = 1";
                using (var checkCmd = new SqlCommand(checkSql, conn, tran))
                {
                    checkCmd.Parameters.AddWithValue("@ChamadoID", message.ChamadoID);
                    int existingSolutions = (int)checkCmd.ExecuteScalar();
                    if (existingSolutions > 0)
                    {
                        tran.Rollback();
                        return false; // Já existe uma solução registrada
                    }
                }

                // Insere a mensagem marcada como solução pendente de aprovação.
                string insertSql = @"
            INSERT INTO HISTORICOCHAMADO 
                (ChamadoID, UsuarioID, Mensagem, DataRegistro, IsSolution, SolutionPendingApproval)
            VALUES 
                (@ChamadoID, @UsuarioID, @Mensagem, @DataRegistro, 1, 1)";
                using (var insertCmd = new SqlCommand(insertSql, conn, tran))
                {
                    insertCmd.Parameters.AddWithValue("@ChamadoID", message.ChamadoID);
                    insertCmd.Parameters.AddWithValue("@UsuarioID", message.UsuarioID);
                    insertCmd.Parameters.AddWithValue("@Mensagem", message.Mensagem);
                    insertCmd.Parameters.AddWithValue("@DataRegistro", message.DataRegistro);
                    insertCmd.ExecuteNonQuery();
                }

                // Atualiza o status do chamado para indicar que há uma solução pendente de aprovação.
                string updateSql = @"UPDATE CHAMADO SET Status = 'Aguardando Aprovação' WHERE ChamadoID = @ChamadoID";
                using (var updateCmd = new SqlCommand(updateSql, conn, tran))
                {
                    updateCmd.Parameters.AddWithValue("@ChamadoID", message.ChamadoID);
                    updateCmd.ExecuteNonQuery();
                }

                tran.Commit();
                return true;
            }
            catch
            {
                tran.Rollback();
                throw;
            }
        }
        // Marca uma solução como aprovada (retira a pendência de aprovação).
        public void MarkSolutionApproved(int historicoId)
        {
            using var conn = Database.GetConnection();
            conn.Open();
            string sql = @"UPDATE HISTORICOCHAMADO
                       SET SolutionPendingApproval = 0
                       WHERE HistoricoID = @HistoricoID";
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@HistoricoID", historicoId);
            cmd.ExecuteNonQuery();
        }
        // Rejeita uma solução, desmarcando os campos de solução e pendência.
        public void MarkSolutionRejected(int historicoId)
        {
            using var conn = Database.GetConnection();
            conn.Open();
            string sql = @"UPDATE HISTORICOCHAMADO
                       SET IsSolution = 0, SolutionPendingApproval = 0
                       WHERE HistoricoID = @HistoricoID";
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@HistoricoID", historicoId);
            cmd.ExecuteNonQuery();
        }
        // Retorna a solução pendente de aprovação de um chamado, se existir.
        public Message GetPendingSolution(int chamadoId)
        {
            using var conn = Database.GetConnection();
            conn.Open();

            string sql = @"
        SELECT TOP 1 * 
        FROM HISTORICOCHAMADO
        WHERE ChamadoID = @ChamadoID AND IsSolution = 1 AND SolutionPendingApproval = 1
        ORDER BY DataRegistro ASC";

            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ChamadoID", chamadoId);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new Message
                {
                    HistoricoID = (int)reader["HistoricoID"],
                    ChamadoID = (int)reader["ChamadoID"],
                    UsuarioID = (int)reader["UsuarioID"],
                    Mensagem = reader["Mensagem"].ToString(),
                    DataRegistro = (DateTime)reader["DataRegistro"],
                    IsSolution = (bool)reader["IsSolution"],
                    SolutionPendingApproval = (bool)reader["SolutionPendingApproval"]
                };
            }
            return null; // Nenhuma solução pendente encontrada
        }
    }
}
