using Microsoft.Data.SqlClient;
using SistemaChamados.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaChamados.Core.Models;


namespace SistemaChamados.Core.Repositories
{
    // Repositório responsável pelas operações de acesso à tabela FAQ.
    public class FAQRepository
    {
        // Insere uma nova FAQ vinculada a um chamado, evitando duplicidades.
        public void InsertFAQ(int sourceChamadoId, string question, string answer)
        {
            using var conn = Database.GetConnection();
            conn.Open();

            // Verifica se já existe uma FAQ gerada a partir do mesmo chamado.
            string checkSql = @"SELECT COUNT(*) FROM FAQ WHERE FonteChamadoID = @FonteChamadoID";
            using var checkCmd = new SqlCommand(checkSql, conn);
            checkCmd.Parameters.AddWithValue("@FonteChamadoID", sourceChamadoId);
            int exists = (int)checkCmd.ExecuteScalar();
            if (exists > 0) return; // Já existe registro vinculado.

            // Insere novo registro de FAQ.
            string insertSql = @"
            INSERT INTO FAQ (Pergunta, Resposta, FonteChamadoID, DataCriacao)
            VALUES (@Pergunta, @Resposta, @FonteChamadoID, @DataCriacao)";

            using var insertCmd = new SqlCommand(insertSql, conn);
            insertCmd.Parameters.AddWithValue("@Pergunta", question);
            insertCmd.Parameters.AddWithValue("@Resposta", answer);
            insertCmd.Parameters.AddWithValue("@FonteChamadoID", sourceChamadoId);
            insertCmd.Parameters.AddWithValue("@DataCriacao", DateTime.Now);
            insertCmd.ExecuteNonQuery();
        }
        // Retorna registros do FAQ cadastrados, com opção de filtrar apenas as aprovados.
        public List<Faq> GetAll(bool onlyApproved = true)
        {
            var faqs = new List<Faq>();
            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string query = onlyApproved
                    ? "SELECT * FROM FAQ WHERE Aprovado = 1 ORDER BY DataCriacao DESC"
                    : "SELECT * FROM FAQ ORDER BY DataCriacao DESC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        faqs.Add(new Faq
                        {
                            FaqID = (int)reader["FaqID"],
                            Pergunta = reader["Pergunta"].ToString(),
                            Resposta = reader["Resposta"].ToString(),
                            FonteChamadoID = (int)reader["FonteChamadoID"],
                            DataCriacao = (DateTime)reader["DataCriacao"],
                            Aprovado = (bool)reader["Aprovado"],
                            Visualizacoes = (int)reader["Visualizacoes"]
                        });
                    }
                }
            }
            return faqs;
        }
        // Retorna as FAQs mais visualizadas e aprovadas.
        public List<Faq> GetTopFaqs()
        {
            var list = new List<Faq>();
            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM FAQ WHERE Aprovado = 1 ORDER BY Visualizacoes DESC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Faq
                        {
                            FaqID = (int)reader["FaqID"],
                            FonteChamadoID = (int)reader["FonteChamadoID"],
                            Pergunta = reader["Pergunta"].ToString(),
                            Resposta = reader["Resposta"].ToString(),
                            Visualizacoes = (int)reader["Visualizacoes"]
                        });
                    }
                }
            }
            return list;
        }
        // Define o status de aprovação de uma FAQ específica.
        public void SetApproval(int faqId, bool aprovado)
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string query = "UPDATE FAQ SET Aprovado = @Aprovado WHERE FaqID = @FaqID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@FaqID", faqId);
                    cmd.Parameters.AddWithValue("@Aprovado", aprovado);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        // Incrementa o contador de visualizações de um FAQ selecionado.
        public void IncrementVisualizacao(int faqId)
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string query = "UPDATE FAQ SET Visualizacoes = Visualizacoes + 1 WHERE FaqID = @FaqID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@FaqID", faqId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }

}
