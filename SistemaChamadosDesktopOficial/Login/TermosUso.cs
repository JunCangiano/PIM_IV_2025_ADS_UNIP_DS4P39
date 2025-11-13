using SistemaChamados.Core.Models;
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

namespace SistemaChamadosDesktopOficial.Login
{
    // Formulário que exibe os Termos de Uso e registra o aceite do usuário
    public partial class TermosUso : Form
    {
        private readonly User _user; // Armazena o usuário logado
        private readonly UserService _userService = new(); // Serviço responsável por atualizar o usuário

        public TermosUso(User user) // Construtor que recebe o usuário atual
        {
            _user = user;
            InitializeComponent();
        }
        // Exibe o texto dos termos quando o link é clicado
        private void linkTermos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            rtbTermos.Visible = true;
        }
        // Ação ao clicar em "Continuar"
        private void btnContinuar_Click(object sender, EventArgs e)
        {
            // Verifica se o usuário aceitou os termos
            if (!chkAceito.Checked)
            {
                MessageBox.Show("Você precisa aceitar os termos de uso para continuar.",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Atualiza o status do usuário para "aceitou os termos"
                _user.AceitouTermos = true;
                _userService.UpdateUser(_user);

                // Abre a página principal e oculta o formulário atual
                var main = new MainPage();
                main.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                // Exibe erro caso a atualização falhe
                MessageBox.Show("Erro ao registrar aceite dos termos: " + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
