using Microsoft.Data.SqlClient;
using SistemaChamados.Core.Data;
using SistemaChamados.Core.Models;
using SistemaChamados.Core.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SistemaChamados.Core.Repositories
{
    public class TicketRepository
    {
        // Retorna todos os chamados com informações do solicitante e responsável.
        public List<Ticket> GetTickets()
        {
            var tickets = new List<Ticket>();

            using var conn = Database.GetConnection();
            conn.Open();

            string sql = @"
                SELECT c.ChamadoID, c.Titulo, c.Descricao, c.Status, c.Prioridade, c.DataAbertura,
                       s.UsuarioID AS SolicitanteID, s.Nome AS SolicitanteNome,
                       r.UsuarioID AS ResponsavelID, r.Nome AS ResponsavelNome,
                       c.DepartamentoID
                FROM CHAMADO c
                INNER JOIN USUARIO s ON c.SolicitanteID = s.UsuarioID
                LEFT JOIN USUARIO r ON c.ResponsavelID = r.UsuarioID";

            using var cmd = new SqlCommand(sql, conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                tickets.Add(new Ticket
                {
                    ChamadoID = (int)reader["ChamadoID"],
                    Titulo = reader["Titulo"].ToString(),
                    Descricao = reader["Descricao"].ToString(),
                    Status = reader["Status"].ToString(),
                    Prioridade = reader["Prioridade"].ToString(),
                    DataAbertura = (DateTime)reader["DataAbertura"],
                    SolicitanteID = (int)reader["SolicitanteID"],
                    SolicitanteNome = reader["SolicitanteNome"].ToString(),
                    ResponsavelID = reader["ResponsavelID"] == DBNull.Value ? null : (int?)reader["ResponsavelID"],
                    ResponsavelNome = reader["ResponsavelNome"] == DBNull.Value ? null : reader["ResponsavelNome"].ToString(),
                    DepartamentoID = (int)reader["DepartamentoID"]
                });
            }

            return tickets;
        }
        // Retorna os chamados de um departamento específico.
        public List<Ticket> GetTicketsByDepartment(int departamentoId)
        {
            var tickets = new List<Ticket>();

            using var conn = Database.GetConnection();
            conn.Open();

            string sql = @"
                SELECT c.ChamadoID, c.Titulo, c.Descricao, c.Status, c.Prioridade, c.DataAbertura,
                       s.UsuarioID AS SolicitanteID, s.Nome AS SolicitanteNome,
                       r.UsuarioID AS ResponsavelID, r.Nome AS ResponsavelNome,
                       c.DepartamentoID
                FROM CHAMADO c
                INNER JOIN USUARIO s ON c.SolicitanteID = s.UsuarioID
                LEFT JOIN USUARIO r ON c.ResponsavelID = r.UsuarioID
                WHERE c.DepartamentoID = @DepartamentoID";

            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@DepartamentoID", departamentoId);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                tickets.Add(new Ticket
                {
                    ChamadoID = (int)reader["ChamadoID"],
                    Titulo = reader["Titulo"].ToString(),
                    Descricao = reader["Descricao"].ToString(),
                    Status = reader["Status"].ToString(),
                    Prioridade = reader["Prioridade"].ToString(),
                    DataAbertura = (DateTime)reader["DataAbertura"],
                    SolicitanteID = (int)reader["SolicitanteID"],
                    SolicitanteNome = reader["SolicitanteNome"].ToString(),
                    ResponsavelID = reader["ResponsavelID"] == DBNull.Value ? null : (int?)reader["ResponsavelID"],
                    ResponsavelNome = reader["ResponsavelNome"] == DBNull.Value ? null : reader["ResponsavelNome"].ToString(),
                    DepartamentoID = (int)reader["DepartamentoID"]
                });
            }

            return tickets;
        }
        // Insere um novo chamado e retorna o ID gerado.
        public int AddTicket(Ticket ticket)
        {
            using var conn = Database.GetConnection();
            conn.Open();

            string sql = @"
        INSERT INTO CHAMADO (Titulo, Descricao, Status, Prioridade, SolicitanteID, DepartamentoID)
        OUTPUT INSERTED.ChamadoID
        VALUES (@Titulo, @Descricao, @Status, @Prioridade, @SolicitanteID, @DepartamentoID)";

            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Titulo", ticket.Titulo);
            cmd.Parameters.AddWithValue("@Descricao", ticket.Descricao);
            cmd.Parameters.AddWithValue("@Status", ticket.Status ?? "Aberto");
            cmd.Parameters.AddWithValue("@Prioridade", ticket.Prioridade ?? "Média");
            cmd.Parameters.AddWithValue("@SolicitanteID", ticket.SolicitanteID);
            cmd.Parameters.AddWithValue("@DepartamentoID", ticket.DepartamentoID);

            return (int)cmd.ExecuteScalar();
        }
        // Retorna a quantidade de chamados com um determinado status.
        public int GetTicketCountByStatus(string status)
        {
            using var conn = Database.GetConnection();
            conn.Open();

            string sql = "SELECT COUNT(*) FROM CHAMADO WHERE Status = @Status";
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Status", status);

            return (int)cmd.ExecuteScalar();
        }
        // Atribui um técnico ao chamado e atualiza o status.
        public void AssignTicket(int ticketId, int technicianId)
        {
            using var conn = Database.GetConnection();
            conn.Open();

            string sql = @"
                UPDATE CHAMADO
                SET ResponsavelID = @TechnicianID, Status = 'Atribuído'
                WHERE ChamadoID = @ChamadoID";

            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@TechnicianID", technicianId);
            cmd.Parameters.AddWithValue("@ChamadoID", ticketId);
            cmd.ExecuteNonQuery();
        }
        // Remove o técnico atribuído e reabre o chamado.
        public void UnassignTicket(int ticketId)
        {
            using var conn = Database.GetConnection();
            conn.Open();

            string sql = @"
        UPDATE CHAMADO
        SET ResponsavelID = NULL, Status = 'Aberto'
        WHERE ChamadoID = @ChamadoID";

            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ChamadoID", ticketId);
            cmd.ExecuteNonQuery();
        }
        // Busca um chamado específico pelo ID.
        public Ticket GetTicketById(int ticketId)
        {
            using var conn = Database.GetConnection();
            conn.Open();

            string sql = @"SELECT * FROM CHAMADO WHERE ChamadoID = @TicketID";
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@TicketID", ticketId);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new Ticket
                {
                    ChamadoID = (int)reader["ChamadoID"],
                    Titulo = reader["Titulo"].ToString(),
                    Descricao = reader["Descricao"].ToString(),
                    Status = reader["Status"].ToString(),
                    Prioridade = reader["Prioridade"].ToString(),
                    SolicitanteID = (int)reader["SolicitanteID"],
                    ResponsavelID = reader["ResponsavelID"] == DBNull.Value ? (int?)null : (int)reader["ResponsavelID"],
                    DepartamentoID = (int)reader["DepartamentoID"]
                };
            }

            return null;
        }
        // Atualiza o status de um chamado e define a data de fechamento se aplicável.
        public void UpdateTicketStatus(int chamadoId, string status)
        {
            using var conn = Database.GetConnection();
            conn.Open();

            string sql = @"
            UPDATE CHAMADO
            SET Status = @Status,
            DataFechamento = CASE 
                                WHEN @Status = 'Fechado' THEN GETDATE()
                                ELSE DataFechamento
                             END
            WHERE ChamadoID = @ChamadoID";

            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Status", status);
            cmd.Parameters.AddWithValue("@ChamadoID", chamadoId);
            cmd.ExecuteNonQuery();
        }
        // Retorna total de chamados agrupados por status.
        public DataTable GetTicketsByStatus()
        {
            using var conn = Database.GetConnection();
            conn.Open();

            string query = "SELECT Status, COUNT(*) AS Total FROM Chamado GROUP BY Status;";
            using var cmd = new SqlCommand(query, conn);
            using var adapter = new SqlDataAdapter(cmd);
            var dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        // Retorna total de chamados agrupados por prioridade.
        public DataTable GetTicketsByPriority()
        {
            using var conn = Database.GetConnection();
            conn.Open();

            string query = "SELECT Prioridade, COUNT(*) AS Total FROM Chamado GROUP BY Prioridade;";
            using var cmd = new SqlCommand(query, conn);
            using var adapter = new SqlDataAdapter(cmd);
            var dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        // Retorna número de chamados abertos por dia nos últimos X dias.
        public DataTable GetTicketsOpenedPerDay(int days = 30)
        {
            using var conn = Database.GetConnection();
            conn.Open();

            string query = @"
            SELECT CAST(DataAbertura AS DATE) AS Dia, COUNT(*) AS Total 
            FROM Chamado
            WHERE DataAbertura >= DATEADD(DAY, -@Days, GETDATE())
            GROUP BY CAST(DataAbertura AS DATE)
            ORDER BY Dia;";
            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Days", days);
            using var adapter = new SqlDataAdapter(cmd);
            var dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        // Retorna total de chamados por técnico (ou sem responsável).
        public DataTable GetTicketsByTechnician()
        {
            using var conn = Database.GetConnection();
            conn.Open();

            string query = @"
            SELECT 
                COALESCE(U.Nome, 'Sem Responsável') AS Responsavel, 
                COUNT(*) AS Total
            FROM Chamado C
            LEFT JOIN Usuario U ON C.ResponsavelID = U.UsuarioID
            GROUP BY COALESCE(U.Nome, 'Sem Responsável');";
            using var cmd = new SqlCommand(query, conn);
            using var adapter = new SqlDataAdapter(cmd);
            var dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }
}
