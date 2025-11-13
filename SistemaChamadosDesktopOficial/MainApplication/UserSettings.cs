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

namespace SistemaChamadosDesktopOficial.MainApplication
{
    // Controle de usuário responsável pelas configurações de perfil do usuário logado
    public partial class UserSettings : UserControl
    {
        // Serviço responsável por operações com usuários e departamentos
        private readonly UserService _userService = new UserService();

        public UserSettings()
        {
            InitializeComponent();
            LoadCurrentUser(); // Carrega as informações do usuário atual ao iniciar
        }
        // Carrega os dados do usuário logado na interface
        private void LoadCurrentUser()
        {
            var user = Session.CurrentUser;
            if (user == null) return;

            // Preenche os campos com os dados atuais do usuário
            txtNome.Text = user.Nome;
            txtEmail.Text = user.Email;
            txtTelefone.Text = user.Telefone;

            // Exibe o cargo do usuário de acordo com o nível de permissão (CRUDID)
            txtCargo.Text = GetCargoName(user.CRUDID);

            // Busca o nome do departamento com base no ID armazenado
            var departamentos = _userService.GetDepartments();
            var dept = departamentos.FirstOrDefault(d => d.Id == user.DepartamentoID);
            txtDepartamento.Text = dept != default ? dept.Nome : "";
        }
        // Valida os dados do formulário antes de salvar
        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("O nome é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("O email é obrigatório.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            // Se o usuário informou uma senha, confirma se as duas coincidem
            if (!string.IsNullOrEmpty(txtSenha.Text))
            {
                if (txtSenha.Text != txtConfirmSenha.Text)
                {
                    MessageBox.Show("As senhas não conferem.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            return true;
        }
        // Retorna o nome do cargo conforme o nível de permissão (CRUDID)
        public static string GetCargoName(int crudId)
        {
            return crudId switch
            {
                1 => "Administrador",
                2 => "Técnico",
                3 => "Colaborador",
                _ => "Desconhecido"
            };
        }
        // Evento: clique no botão de salvar alterações no perfil
        private void btnSaveProfile_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;// Valida antes de salvar

            var user = Session.CurrentUser;
            if (user == null) return;

            // Atualiza os dados do usuário com os novos valores informados
            user.Nome = txtNome.Text.Trim();
            user.Email = txtEmail.Text.Trim();
            user.Telefone = txtTelefone.Text.Trim();

            // Se o usuário alterou a senha, gera o novo hash
            if (!string.IsNullOrEmpty(txtSenha.Text))
            {
                user.SenhaHash = PasswordHasher.Hash(txtSenha.Text.Trim());
            }

            // Mantém o cargo e o departamento atuais
            _userService.UpdateUser(user);

            MessageBox.Show("Perfil atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Atualiza a sessão com as novas informações
            Session.CurrentUser = user;
        }
        // Evento: clique no botão para revogar aceite dos termos de uso
        private void btnRvkUsrTrm_Click(object sender, EventArgs e)
        {
            var user = Session.CurrentUser;
            user.AceitouTermos = false; // Marca o usuário como não tendo aceitado os termos
            _userService.UpdateUser(user);
            MessageBox.Show("Termos de uso revogados com sucesso! No próximo login deverá aceitá-los novamente para continuar utilizando o ChamadinTech", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
