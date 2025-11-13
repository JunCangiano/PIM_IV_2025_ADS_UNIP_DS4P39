using SistemaChamados.Core.Models;
using SistemaChamados.Core.Repositories;
using SistemaChamados.Core.Utils;
using SistemaChamadosDesktopOficial.MainApplication;
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
    public partial class MainPage : Form
    {
        // Instancia os UserControls que representam cada página do sistema
        private HomePage HomePage = new HomePage();
        private NewTicket NewTicket = new NewTicket();
        private Tickets Tickets = new Tickets();
        private Calendar Calendar = new Calendar();
        private Settings Settings = new Settings();
        private UserSettings UserSettings = new UserSettings();
        private FAQAdmin FAQAdmin = new FAQAdmin();
        private FAQUser FAQUser = new FAQUser();

        public MainPage()
        {
            InitializeComponent();
            userProfile.Text = Session.CurrentUser.Nome; // Exibe o nome do usuário logado
        }
        // Evento disparado ao carregar o form
        private void MainPage_Load(object sender, EventArgs e)
        {
            LoadPage(new HomePage()); // Carrega a página inicial ao abrir o sistema
        }
        // Método central que carrega um UserControl dentro do painel principal
        private void LoadPage(UserControl page)
        {
            mainContent.Controls.Clear(); // Remove qualquer conteúdo anterior do painel
            page.Dock = DockStyle.Fill;   // Faz o UserControl ocupar todo o painel
            mainContent.Controls.Add(page); // Adiciona o UserControl ao painel

            // Mostra o botão de configuração apenas para administradores (CRUDID = 1)
            if (Session.CurrentUser.CRUDID == 1) BtnConfig.Visible = true;
        }
        // Botão Home: carrega a página inicial
        private void BtnHome_Click(object sender, EventArgs e)
        {
            LoadPage(HomePage);
        }
        // Botão Forms: carrega a página de abertura de novos chamados
        private void BtnForms_Click(object sender, EventArgs e)
        {
            LoadPage(NewTicket); // Página para abertura de novos chamados
        }
        // Botão Tickets: carrega a página de acompanhamento de chamados
        private void BtnTickets_Click(object sender, EventArgs e)
        {
            LoadPage(Tickets);
        }
        // Botão Plans: carrega a página do calendário/planejamento
        private void BtnPlans_Click(object sender, EventArgs e)
        {
            LoadPage(Calendar);
        }
        // Botão Config: carrega a central de colaboradores (restrita a admins)
        private void BtnConfig_Click(object sender, EventArgs e)
        {
            if (Session.CurrentUser.CRUDID != 1)// Verifica se é admin
            {
                MessageBox.Show("Somente administradores do sistema podem acessar a Central de Colaboradores!", "Área restrita!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;// Sai do método se não for admin
            }
            LoadPage(Settings);// Carrega a página de configurações
        }
        // Botão Logout: encerra o sistema
        private void Logout_Click(object sender, EventArgs e)
        {

            // Confirmar se o usuário deseja encerra a sessão
            var result = MessageBox.Show(
                "Deseja encerrar a sessão atual?",
                "Confirmar logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                // Limpa dados da sessão atual
                Session.End();

                // Esconde a página atual
                this.Hide();

                // Reabre a página de login
                var login = new LoginPage();
                login.Show();

                // Fecha a home depois de reabrir o login
                this.Close();
            }
        }
        // Botão FAQ: carrega o painel de edição do FAQ (somente admin)
        private void btnFaq_Click(object sender, EventArgs e)
        {
            if (Session.CurrentUser.CRUDID == 3)
            {
                LoadPage(FAQUser);
                return;
            }
            LoadPage(FAQAdmin);
        }
        // Clique no perfil do usuário: carrega a página de edição do próprio perfil
        private void userProfile_Click(object sender, EventArgs e)
        {
            LoadPage(UserSettings);// Permite que o usuário edite suas informações
        }
    }
}
