using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaChamados.Core.Models
{
    // Representa um item da base de conhecimento (FAQ) do sistema.
    public class Faq
    {
        // Identificador único do registro da FAQ.
        public int FaqID { get; set; }

        // Pergunta frequente registrada.
        public string Pergunta { get; set; }

        // Resposta ou instrução correspondente.
        public string Resposta { get; set; }

        // ID do chamado que originou a FAQ.
        public int FonteChamadoID { get; set; }

        // Data de criação do registro.
        public DateTime DataCriacao { get; set; }

        // Indica se a FAQ foi revisada e aprovada.
        public bool Aprovado { get; set; }

        // Contador de visualizações do artigo.
        public int Visualizacoes { get; set; }
    }
}
