using Microsoft.Data.SqlClient;
using SistemaChamados.Core.Data;
using SistemaChamados.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaChamados.Core.Repositories
{
    // Repositório responsável pelas operações de acesso a dados da tabela DEPARTAMENTO.
    public class DepartamentoRepository
    {
        // Retorna todos os departamentos cadastrados no banco de dados.
        public List<Department> GetAll()
        {
            var departamentos = new List<Department>();

            using (var conn = Database.GetConnection())
            {
                conn.Open();

                // Consulta todos os registros da tabela DEPARTAMENTO.
                var cmd = new SqlCommand("SELECT CategoriaID, NomeCategoria FROM DEPARTAMENTO", conn);
                using (var reader = cmd.ExecuteReader())
                {
                    // Lê cada registro e instancia objetos Department.
                    while (reader.Read())
                    {
                        departamentos.Add(new Department
                        {
                            Id = reader.GetInt32(0),
                            Nome = reader.GetString(1)
                        });
                    }
                }
            }

            return departamentos;
        }

    }

}
