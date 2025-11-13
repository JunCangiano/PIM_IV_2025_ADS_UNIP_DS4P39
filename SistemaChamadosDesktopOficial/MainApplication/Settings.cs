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


namespace SistemaChamadosDesktopOficial.MainApplication
{
    // UserControl de gerenciamento de usuários
    public partial class Settings : UserControl
    {
        private readonly UserService _userService = new UserService(); // Serviço de usuários
        private List<User> _users; // Lista local de usuários carregados

        public Settings()
        {
            InitializeComponent();
            LoadUsers();       // Carrega a tabela de usuários
            LoadComboBoxes();  // Carrega cargos e departamentos
        }

        private void LoadUsers()
        {
            // Obtém todos os usuários e exibe na tabela
            _users = _userService.GetAllUsers();
            dgvUsers.DataSource = _users.Select(u => new
            {
                u.UsuarioID,
                u.Nome,
                u.Email,
                u.Telefone,
                Ativo = u.Ativo ? "Ativo" : "Inativo",
                Cargo = GetCargoName(u.CRUDID),
                Departamento = u.DepartamentoNome
            }).ToList();

            dgvUsers.ClearSelection();
            ClearForm();
        }
        private void LoadComboBoxes()
        {
            // Preenche o combo de cargos e departamentos
            cboCargo.DataSource = new List<string> { "Administrador", "Técnico", "Colaborador" };

            var departamentos = _userService.GetDepartments();
            cboDepartamento.DataSource = departamentos;
            cboDepartamento.DisplayMember = "Nome";
            cboDepartamento.ValueMember = "Id";
        }
        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            btnAnonymizeUser.Visible = true;

            // Obtém o usuário selecionado
            int selectedUserId = Convert.ToInt32(dgvUsers.Rows[e.RowIndex].Cells["UsuarioID"].Value);
            var user = _users.FirstOrDefault(u => u.UsuarioID == selectedUserId);
            if (user == null) return;

            // Preenche o formulário com os dados
            txtNome.Text = user.Nome;
            txtEmail.Text = user.Email;
            txtTelefone.Text = user.Telefone;
            chkAtivo.Checked = user.Ativo;
            cboCargo.SelectedItem = GetCargoName(user.CRUDID);
            cboDepartamento.SelectedValue = user.DepartamentoID;

            // Impede ações sobre si mesmo
            bool isSelf = Session.CurrentUser?.UsuarioID == user.UsuarioID;
            btnAnonymizeUser.Visible = !isSelf;
            cboCargo.Enabled = !isSelf;
            chkAtivo.Enabled = !isSelf;
        }
        private void ClearForm()
        {
            // Limpa campos e reseta botões
            txtNome.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();
            chkAtivo.Checked = true;
            cboCargo.SelectedIndex = -1;
            cboDepartamento.SelectedIndex = -1;
            chkAtivo.Enabled = true;
            cboCargo.Enabled = true;
            btnAnonymizeUser.Visible = false;
            dgvUsers.ClearSelection();
        }
        private bool ValidateForm(bool allowEmpty = false)
        {
            // Valida campos obrigatórios
            if (!allowEmpty && string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("O campo Nome é obrigatório.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!allowEmpty && string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("O campo Email é obrigatório.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cboCargo.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um cargo.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cboDepartamento.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um departamento.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        // Conversões entre ID e nome de cargo
        private static int GetCargoId(string cargoNome) => cargoNome switch
        {
            "Administrador" => 1,
            "Técnico" => 2,
            "Colaborador" => 3,
            _ => 3
        };
        private static string GetCargoName(int cargoId) => cargoId switch
        {
            1 => "Administrador",
            2 => "Técnico",
            3 => "Colaborador",
            _ => "Colaborador"
        };
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            // Monta objeto de usuário
            string cargoNome = cboCargo.SelectedItem?.ToString() ?? "Colaborador";
            int cargoId = GetCargoId(cargoNome);

            var updatedUser = new User
            {
                Nome = txtNome.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Telefone = txtTelefone.Text.Trim(),
                Ativo = chkAtivo.Checked,
                CRUDID = cargoId,
                DepartamentoID = (int)cboDepartamento.SelectedValue
            };

            // Novo usuário
            if (dgvUsers.CurrentRow == null || dgvUsers.SelectedRows.Count == 0)
            {
                // Impede duplicidade de e-mail
                if (_userService.EmailExists(updatedUser.Email) &&
                    _users.Any(u => u.Email.Equals(updatedUser.Email, StringComparison.OrdinalIgnoreCase) && u.UsuarioID != updatedUser.UsuarioID))
                {
                    MessageBox.Show("Este e-mail já pertence a outro usuário.", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                _userService.CreateUser(updatedUser);
                MessageBox.Show("Novo usuário criado com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Atualização de usuário
                int selectedUserId = (int)dgvUsers.CurrentRow.Cells["UsuarioID"].Value;
                updatedUser.UsuarioID = selectedUserId;
                _userService.UpdateUser(updatedUser);
                MessageBox.Show("Usuário atualizado com sucesso!", "Sucesso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            ClearForm();
            LoadUsers();
        }
        private void btnRefreshList_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }
        private void btnClearForm_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
        private void btnRstPassword_Click(object sender, EventArgs e)
        {
            if (!ValidateForm(true)) return;

            if (dgvUsers.CurrentRow == null)
            {
                MessageBox.Show("Selecione um usuário para redefinir a senha.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedUserId = Convert.ToInt32(dgvUsers.CurrentRow.Cells["UsuarioID"].Value);
            var user = _users.FirstOrDefault(u => u.UsuarioID == selectedUserId);
            if (user == null) return;

            bool isSelf = Session.CurrentUser?.UsuarioID == user.UsuarioID;
            if (isSelf)
            {
                MessageBox.Show("Você não pode redefinir sua própria senha.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Confirmação antes de redefinir
            var confirm = MessageBox.Show(
                $"Deseja realmente redefinir a senha de {user.Nome} para '123456'?",
                "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
                return;

            _userService.ResetPassword(user.UsuarioID, "123456");

            MessageBox.Show("Senha redefinida com sucesso!", "Sucesso",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnAnonymizeUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow == null)
            {
                MessageBox.Show("Nenhum usuário selecionado.");
                return;
            }

            int selectedUserId = Convert.ToInt32(dgvUsers.CurrentRow.Cells["UsuarioID"].Value);
            var user = _users.FirstOrDefault(u => u.UsuarioID == selectedUserId);
            if (user == null)
            {
                MessageBox.Show("Usuário não encontrado.");
                return;
            }

            // Impede anonimizar a si mesmo
            if (Session.CurrentUser?.UsuarioID == user.UsuarioID)
            {
                MessageBox.Show("Você não pode anonimizar a si mesmo.", "Ação Bloqueada",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show(
                "Tem certeza que deseja anonimizar este usuário? Essa ação é irreversível.",
                "Confirmar Anonimização",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.Yes)
            {
                // Anonymize by email as your service expects
                _userService.AnonymizeUser(user.Email);

                MessageBox.Show("Usuário anonimizado e desativado com sucesso.",
                    "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadUsers();
                ClearForm();
            }
        }
    }
}
