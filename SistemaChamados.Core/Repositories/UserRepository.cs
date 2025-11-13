using Microsoft.Data.SqlClient;
using SistemaChamados.Core.Data;
using SistemaChamados.Core.Models;
using SistemaChamados.Core.Utils;

namespace SistemaChamados.Core.Repositories
{
    public class UserRepository
    {
        // Retorna o ID de um usuário pelo nome
        public int GetUserIdByName(string userName)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand("SELECT UsuarioID FROM USUARIO WHERE Nome = @Nome", conn);
                cmd.Parameters.AddWithValue("@Nome", userName);

                var result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : 0;
            }
        }
        // Retorna todos os usuários com dados de departamento
        public List<User> GetAllUsers()
        {
            var users = new List<User>();

            using var connection = Database.GetConnection();
            connection.Open();

            string sql = @"
        SELECT u.UsuarioID, u.Nome, u.Email, u.Telefone, u.Ativo, u.CRUDID, 
               u.DepartamentoID, d.NomeCategoria AS DepartamentoNome
        FROM USUARIO u
        LEFT JOIN DEPARTAMENTO d ON u.DepartamentoID = d.CategoriaID";

            using var cmd = new SqlCommand(sql, connection);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                users.Add(new User
                {
                    UsuarioID = reader.GetInt32(reader.GetOrdinal("UsuarioID")),
                    Nome = reader.GetString(reader.GetOrdinal("Nome")),
                    Email = reader.GetString(reader.GetOrdinal("Email")),
                    Telefone = reader.IsDBNull(reader.GetOrdinal("Telefone")) ? null : reader.GetString(reader.GetOrdinal("Telefone")),
                    Ativo = reader.GetBoolean(reader.GetOrdinal("Ativo")),
                    CRUDID = reader.GetInt32(reader.GetOrdinal("CRUDID")),
                    DepartamentoID = reader.IsDBNull(reader.GetOrdinal("DepartamentoID")) ? 0 : reader.GetInt32(reader.GetOrdinal("DepartamentoID")),
                    DepartamentoNome = reader.IsDBNull(reader.GetOrdinal("DepartamentoNome")) ? "" : reader.GetString(reader.GetOrdinal("DepartamentoNome"))
                });
            }

            return users;
        }
        // Retorna usuário pelo e-mail
        public User GetByEmail(string email)
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM USUARIO WHERE Email = @Email";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new User
                            {
                                UsuarioID = (int)reader["UsuarioID"],
                                Nome = reader["Nome"].ToString(),
                                Email = reader["Email"].ToString(),
                                SenhaHash = reader["SenhaHash"].ToString(),
                                Telefone = reader.IsDBNull(reader.GetOrdinal("Telefone")) ? null : reader.GetString(reader.GetOrdinal("Telefone")),
                                Ativo = reader.GetBoolean(reader.GetOrdinal("Ativo")),
                                CRUDID = reader.GetInt32(reader.GetOrdinal("CRUDID")),
                                DepartamentoID = reader.IsDBNull(reader.GetOrdinal("DepartamentoID")) ? 0 : reader.GetInt32(reader.GetOrdinal("DepartamentoID")),
                                AceitouTermos = reader.GetBoolean(reader.GetOrdinal("AceitouTermos"))
                            };
                        }
                    }
                }
            }
            return null;
        }
        // Retorna o nível de acesso (CRUDID) do usuário
        public int GetUserRole(int usuarioId)
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string query = "SELECT CRUDID FROM USUARIO WHERE UsuarioID = @UsuarioID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UsuarioID", usuarioId);
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                }
            }
            return 3; // Retorna padrão se não encontrar
        }
        // Atualiza dados do usuário existente
        public void UpdateUser(User user)
        {
           
            using var conn = Database.GetConnection();
            conn.Open();

            string sql = @"UPDATE USUARIO 
                   SET Nome = @Nome, Email = @Email, Telefone = @Telefone, SenhaHash = @SenhaHash,
                       Ativo = @Ativo, CRUDID = @CRUDID, DepartamentoID = @DepartamentoID, AceitouTermos = @AceitouTermos
                   WHERE UsuarioID = @UsuarioID";

            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Nome", user.Nome);
            cmd.Parameters.AddWithValue("@Email", user.Email);
            cmd.Parameters.AddWithValue("@Telefone", user.Telefone ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@SenhaHash", user.SenhaHash);
            cmd.Parameters.AddWithValue("@Ativo", user.Ativo);
            cmd.Parameters.AddWithValue("@CRUDID", user.CRUDID);
            cmd.Parameters.AddWithValue("@DepartamentoID", user.DepartamentoID ?? (object)DBNull.Value);
            cmd.Parameters.AddWithValue("@UsuarioID", user.UsuarioID);
            cmd.Parameters.AddWithValue("@AceitouTermos", user.AceitouTermos);

            cmd.ExecuteNonQuery();
        }
        // Cria um novo usuário
        public void CreateUser(User user)
        {
            using var conn = Database.GetConnection();
            conn.Open();

            string sql = @"
        INSERT INTO USUARIO (Nome, Email, Telefone, Ativo, CRUDID, DepartamentoID, SenhaHash)
        VALUES (@Nome, @Email, @Telefone, @Ativo, @CRUDID, @DepartamentoID, @SenhaHash)";

            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Nome", user.Nome);
            cmd.Parameters.AddWithValue("@Email", user.Email);
            cmd.Parameters.AddWithValue("@Telefone", (object?)user.Telefone ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@Ativo", user.Ativo ? 1 : 0);
            cmd.Parameters.AddWithValue("@CRUDID", user.CRUDID);
            cmd.Parameters.AddWithValue("@DepartamentoID", (object?)user.DepartamentoID ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@SenhaHash", user.SenhaHash ?? PasswordHasher.Hash("123456"));
       
            cmd.ExecuteNonQuery();
        }
        // Redefine a senha de um usuário
        public void ResetPassword(int userId, string hashedPassword)
        {
            using var conn = Database.GetConnection();
            conn.Open();

            string sql = "UPDATE USUARIO SET SenhaHash = @Senha WHERE UsuarioID = @UsuarioID";
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Senha", hashedPassword);
            cmd.Parameters.AddWithValue("@UsuarioID", userId);

            cmd.ExecuteNonQuery();
        }

    }
}
