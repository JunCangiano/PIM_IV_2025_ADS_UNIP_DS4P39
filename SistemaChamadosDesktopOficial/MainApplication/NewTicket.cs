using SistemaChamados.Core.Models;
using SistemaChamados.Core.Services;
using SistemaChamados.Core.Repositories;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SistemaChamadosDesktopOficial.MainApplication
{
    // Classe parcial responsável pelo controle de interface de criação de novos chamados
    public partial class NewTicket : UserControl
    {
        // Instância do serviço de tickets
        private readonly TicketService _ticketService = new();
        // Repositório de usuários, usado para buscar dados dos solicitantes
        private readonly UserRepository _userRepository = new UserRepository();

        public NewTicket()
        {
            InitializeComponent();
            LoadUserData();        // Carrega os nomes dos usuários no combobox
            LoadPriorities();      // Carrega as opções de prioridade do chamado
        }
        // Preencher o combobox com os usuários cadastrados
        private void LoadUserData()
        {
            var users = _userRepository.GetAllUsers(); // Busca todos os usuários do banco (List<User>)
            cboUserName.Items.Clear(); // Limpa os itens existentes do combobox

            // Adiciona o nome de cada usuário no combobox
            foreach (var user in users)
                cboUserName.Items.Add(user.Nome);

            // Seleciona o primeiro item por padrão, se houver
            if (cboUserName.Items.Count > 0)
                cboUserName.SelectedIndex = 0;
        }

        // Método responsável por carregar as prioridades possíveis do chamado
        private void LoadPriorities()
        {
            cboPriority.Items.AddRange(new[] { "Baixa", "Média", "Alta" });
            cboPriority.SelectedIndex = 1;
        }
        // Evento de clique do botão de envio do chamado
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtém o nome do usuário selecionado no combobox
                var userName = cboUserName.SelectedItem?.ToString();

                // Valida se o usuário foi selecionado
                if (string.IsNullOrEmpty(userName))
                {
                    MessageBox.Show("Selecione o solicitante.");
                    return;
                }

                // Busca o ID do solicitante pelo nome
                int solicitanteId = _userRepository.GetUserIdByName(userName);

                // Obtém o ID da categoria selecionada (departamento) através dos RadioButtons
                int? categoryId = GetSelectedCategoryId();

                // Cria um novo objeto Ticket com os dados informados na interface
                var ticket = new Ticket
                {
                    Titulo = txtTitle.Text,
                    Descricao = txtDescription.Text,
                    Status = "Aberto", // Status inicial
                    Prioridade = cboPriority.SelectedItem?.ToString() ?? "Média", // Define prioridade
                    DataAbertura = DateTime.Now, // Define data de criação
                    DataFechamento = null, // Ainda não fechado
                    SolicitanteID = solicitanteId, // ID do usuário que abriu o chamado
                    ResponsavelID = null, // Ainda sem responsável atribuído
                    DepartamentoID = categoryId ?? 0 // Se não houver categoria, define 0 (será validado)
                };

                // Chama o método de validação dentro do serviço
                _ticketService.ValidateTicket(ticket);
                // Cria o chamado no banco de dados
                _ticketService.CreateTicket(ticket);

                MessageBox.Show("Chamado criado com sucesso!");
                ClearForm();
            }
            catch (Exception ex)
            {
                // Captura e exibe qualquer erro ocorrido durante o processo
                MessageBox.Show(ex.Message, "Erro ao criar chamado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Método auxiliar para limpar todos os campos após a criação de um chamado
        private void ClearForm()
        {
            txtTitle.Clear();       // Limpa o campo de título
            txtDescription.Clear(); // Limpa o campo de descrição

            // Restaura a prioridade padrão ("Média")
            if (cboPriority.Items.Count > 0)
                cboPriority.SelectedItem = "Média";

            // Retorna o combobox de usuários para o primeiro item
            if (cboUserName.Items.Count > 0)
                cboUserName.SelectedIndex = 0;

            // Desmarca todos os RadioButtons do painel de departamentos
            foreach (var rb in pnlDepartments.Controls.OfType<RadioButton>())
                rb.Checked = false;
        }

        // Método responsável por identificar qual categoria (departamento) foi selecionada
        private int? GetSelectedCategoryId()
        {
            foreach (RadioButton rb in pnlDepartments.Controls.OfType<RadioButton>())
            {
                // Quando encontrar o selecionado, retorna o ID armazenado no Tag
                if (rb.Checked)
                {
                    return int.Parse(rb.Tag.ToString());
                }
            }
            // Retorna null se nenhum departamento foi selecionado
            return null;
        }


    }
}
