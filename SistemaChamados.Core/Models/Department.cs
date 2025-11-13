using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaChamados.Core.Models
{
    // Representa um departamento ou setor da organização.
    public class Department
    {
        // Identificador único do departamento.
        public int Id { get; set; }

        // Nome do departamento e categoria do chamado.
        public string Nome { get; set; } = string.Empty;
    }
}

