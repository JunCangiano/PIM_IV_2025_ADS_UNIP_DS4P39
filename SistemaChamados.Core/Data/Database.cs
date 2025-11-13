using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace SistemaChamados.Core.Data
{
    // Gerencia a conexão com o banco de dados SQL Server.
    public static class Database
    {
        // String de conexão com parâmetros de acesso ao banco local PIM_IV.
        private static readonly string _connectionString = @"Server=localhost\SQLEXPRESS;Database=PIM_IV;Trusted_Connection=True;TrustServerCertificate=True;";
        
        // Retorna uma nova instância de conexão com o banco de dados.
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
