using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaChamados.Core.Models
{
    // Representa uma mensagem ou interação registrada dentro de um chamado.
    public class Message
    {
        // Identificador único do registro no histórico.
        public int HistoricoID { get; set; }

        // ID do chamado ao qual a mensagem pertence.
        public int ChamadoID { get; set; }

        // ID do usuário que enviou a mensagem.
        public int UsuarioID { get; set; }

        // Nome do usuário autor da mensagem.
        public string UsuarioNome { get; set; } = string.Empty;

        // Perfil do usuário (Administrador, Técnico, Usuário).
        public string CRUDID { get; set; } = string.Empty;

        // Conteúdo textual da mensagem.
        public string Mensagem { get; set; } = string.Empty;

        // Data e hora do registro da mensagem.
        public DateTime DataRegistro { get; set; }

        // Indica se a mensagem contém uma solução.
        public bool IsSolution { get; set; }

        // Indica se a solução está aguardando aprovação.
        public bool SolutionPendingApproval { get; set; }

    }

}
