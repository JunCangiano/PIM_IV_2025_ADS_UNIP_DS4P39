using SistemaChamados.Core.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaChamadosDesktopOficial
{
    // Formulário responsável por iniciar o processo de redefinição de senha.
    public partial class ResetPasswordForm : Form
    {
        // Instância do serviço de usuários.
        private readonly UserService _user = new();

        public ResetPasswordForm()
        {
            InitializeComponent();
        }
        // Evento acionado ao clicar no botão "Login" (ou "Continuar").
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtém o e-mail digitado.
                var email = txtUsuario.Text.Trim();
                // Verifica se o campo está vazio.
                if (string.IsNullOrEmpty(email))
                {
                    MessageBox.Show("Digite seu e-mail.", "Atenção",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Busca o usuário pelo e-mail informado.
                var user = _user.GetUserByEmail(email);
                // Se não encontrar, exibe mensagem de erro.
                if (user == null)
                {
                    MessageBox.Show("E-mail não encontrado.", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Se o usuário for encontrado, abre o formulário para redefinir a senha.
                var redefinirSenha = new RedefinirSenha(user);
                this.Hide(); // Oculta a tela atual.
                redefinirSenha.ShowDialog(); // Exibe a próxima etapa.
                this.Close(); // Fecha a tela após concluir.
            }
            catch (Exception ex)
            {
                // Exibe mensagem genérica de erro em caso de exceção.
                MessageBox.Show("Erro: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
