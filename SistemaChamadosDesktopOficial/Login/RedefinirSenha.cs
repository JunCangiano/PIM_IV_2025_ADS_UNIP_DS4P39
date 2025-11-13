using SistemaChamados.Core.Models;
using SistemaChamados.Core.Services;
using SistemaChamados.Core.Utils;
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
    // Formulário responsável por redefinir a senha do usuário
    public partial class RedefinirSenha : Form
    {
        private readonly User _user;// Usuário cuja senha será redefinida
        private readonly UserService _userService = new();// Serviço de manipulação de dados do usuário

        // Construtor que recebe o usuário
        public RedefinirSenha(User user)
        {
            InitializeComponent();
            _user = user;
        }

        // Evento acionado ao clicar no botão para redefinir senha
        private void btnLogin_Click(object sender, EventArgs e)
        {
            var senha = txtPassword.Text.Trim();
            var confirmar = txtConfirmPassword.Text.Trim();

            // Verifica se os campos estão preenchidos
            if (string.IsNullOrEmpty(senha) || string.IsNullOrEmpty(confirmar))
            {
                MessageBox.Show("Preencha todos os campos.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Verifica se as senhas coincidem
            if (senha != confirmar)
            {
                MessageBox.Show("As senhas não coincidem.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Gera o hash da nova senha e atualiza o usuário
                String newPassword = PasswordHasher.Hash(senha);
                _user.SenhaHash = newPassword;
                _userService.UpdateUser(_user);

                // Exibe mensagem de sucesso e fecha o formulário
                MessageBox.Show("Senha redefinida com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                // Exibe mensagem de erro em caso de falha
                MessageBox.Show("Erro ao redefinir senha: " + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
