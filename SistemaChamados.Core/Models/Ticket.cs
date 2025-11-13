using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaChamados.Core.Models
{
    // Representa um chamado de suporte técnico registrado no sistema.
    public class Ticket
    {
        // Identificador único do chamado.
        public int ChamadoID { get; set; }

        // Título breve que resume o problema.
        public string Titulo { get; set; }

        // Descrição detalhada do chamado.
        public string Descricao { get; set; }

        // Status atual do chamado (Aberto, Em andamento, Resolvido, Fechado).
        public string Status { get; set; }

        // Nível de prioridade (Baixa, Média, Alta, Urgente).
        public string Prioridade { get; set; }

        // Data em que o chamado foi criado.
        public DateTime DataAbertura { get; set; }

        // Data de fechamento (nula enquanto estiver aberto).
        public DateTime? DataFechamento { get; set; }

        // ID do usuário que abriu o chamado.
        public int SolicitanteID { get; set; }

        // Nome do solicitante (campo auxiliar para exibição).
        public string SolicitanteNome { get; set; }

        // ID do técnico responsável (pode ser nulo até a atribuição).
        public int? ResponsavelID { get; set; }

        // Nome do responsável pelo atendimento (campo auxiliar).
        public string ResponsavelNome { get; set; }

        // ID do departamento relacionado ao chamado.
        public int DepartamentoID { get; set; }

        // Nome do departamento (campo auxiliar para exibição).
        public string DepartamentoNome { get; set; }
    }

}
