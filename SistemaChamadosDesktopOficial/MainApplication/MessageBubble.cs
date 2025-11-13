using SistemaChamados.Core.Models;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace SistemaChamadosDesktopOficial.Controls
{
    public partial class MessageBubble : UserControl
    {
        public MessageBubble()
        {
            InitializeComponent();
        }
        // Método responsável por configurar a exibição de uma mensagem no bubble
        // Recebe:
        // - msg: objeto Message com dados da mensagem
        // - crudId: string que representa o cargo do usuário (1 = Admin, 2 = Técnico, 3 = Colaborador)
        // - isSolution: booleano indicando se a mensagem é uma solução aprovada
        public void SetMessage(SistemaChamados.Core.Models.Message msg, String crudId, bool isSolution = false)
        {
            // Configura o cabeçalho da mensagem com nome do usuário e data
            lblUser.Text = $"{msg.UsuarioNome} ({msg.DataRegistro:dd/MM/yyyy HH:mm})";
            // Conteúdo da mensagem
            lblText.Text = msg.Mensagem;

            // Estilo padrão
            lblUser.ForeColor = Color.Gray;       // Usuário em cinza
            lblText.ForeColor = Color.Black;      // Texto em preto
            lblText.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            lblText.BackColor = Color.WhiteSmoke; // Fundo padrão
            Padding = new Padding(8);             // Espaçamento interno
            BackColor = Color.Transparent;        // Fundo do controle transparente inicialmente

            if (isSolution)
            {
                BackColor = Color.LightGreen; // Fundo do bubble verde
                lblText.BackColor = Color.LightGreen;
                lblUser.BackColor = Color.LightGreen;
                lblText.Font = new Font("Segoe UI", 9, FontStyle.Bold); // Negrito para destaque
                lblUser.Text += " ✅ (Solução)";   // Marca o usuário com indicador de solução
            }
            else
            {
                // Caso não seja solução, aplica cores conforme o cargo do usuário
                switch (crudId)
                {
                    case "1":// admin
                        BackColor = Color.LightYellow;
                        lblText.BackColor = Color.LightYellow;
                        lblUser.BackColor = Color.LightYellow;
                        break; 
                    case "2":// técnico
                        BackColor = Color.LightBlue;
                        lblText.BackColor = Color.LightBlue;
                        lblUser.BackColor = Color.LightBlue; 
                        break;   
                    case "3":// colaborador
                        BackColor = Color.Gainsboro;
                        lblText.BackColor = Color.Gainsboro;
                        lblUser.BackColor = Color.Gainsboro;
                        break;   
                    default: // caso padrão
                        BackColor = Color.WhiteSmoke; 
                        break;
                }
            }
        }
    }
}
