using SistemaChamados.Core.Services;
using SistemaChamados.Core.Utils;
using SistemaChamadosDesktopOficial.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace SistemaChamadosDesktopOficial
{
    // Formulário principal de login do sistema de chamados
    public partial class LoginPage : Form
    {
        // Serviço responsável pela autenticação do usuário
        private readonly LoginService _loginService = new();
        public LoginPage()
        {
            InitializeComponent();
        }
        // Evento: ao entrar no campo de usuário
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            // Se o campo ainda está com o texto padrão, limpa e muda a cor
            if (txtUsuario.Text == "Usuário")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }
        // Evento: ao sair do campo de usuário
        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            // Se o campo ficou vazio, restaura o texto e cor padrão
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                txtUsuario.Text = "Usuário";
                txtUsuario.ForeColor = Color.Gray;
            }
        }
        // Evento: ao entrar no campo de senha
        private void txtSenha_Enter(object sender, EventArgs e)
        {
            // Se o campo ainda está com o texto padrão, limpa e muda a cor
            if (txtSenha.Text == "Senha")
            {
                txtSenha.Text = "";
                txtSenha.ForeColor = Color.Black;
            }
        }
        // Evento: ao sair do campo de senha
        private void txtSenha_Leave(object sender, EventArgs e)
        {
            // Se o campo ficou vazio, restaura o texto e cor padrão
            if (string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                txtSenha.UseSystemPasswordChar = false;
                txtSenha.Text = "Senha";
                txtSenha.ForeColor = Color.Gray;
            }
        }
        // Evento: clique no botão "Login"
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                // Tenta autenticar o usuário com os dados informados
                var user = _loginService.Authenticate(txtUsuario.Text, txtSenha.Text);
                Session.Start(user);// Armazena o usuário na sessão atual

                if (!user.AceitouTermos)
                {
                    // Caso o usuário ainda não tenha aceitado os termos, redireciona para página de aceite
                    var termosForm = new TermosUso(user);
                    termosForm.ShowDialog(); // Bloqueia até aceitar os termos
                    this.Hide();
                    return;
                }

                // Se login OK e termos aceitos direciona a tela principal
                
                var main = new MainPage();
                main.Show();
                this.Hide(); // Esconde a tela de login
            }
            catch (Exception ex)
            {
                // Mostra erro caso falhe a autenticação
                MessageBox.Show(ex.Message, "Erro de login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Evento: clique em "Esqueci minha senha"
        private void ForgotPassword_Click(object sender, EventArgs e)
        {
            // Fecha a tela de login e abre a tela de redefinição de senha
            this.Hide();
            var redefinir = new ResetPasswordForm();
            redefinir.ShowDialog();

            // Quando o formulário for fechado, volta para a tela de login
            this.Show();
        }

    }
}
