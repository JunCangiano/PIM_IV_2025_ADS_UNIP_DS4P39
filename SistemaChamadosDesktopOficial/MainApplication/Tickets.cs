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

namespace SistemaChamadosDesktopOficial.MainApplication
{
    // Controle de interface responsável pela exibição e gerenciamento da lista de chamados
    public partial class Tickets : UserControl
    {
        // Serviço responsável pelas operações relacionadas aos chamados
        private readonly TicketService _ticketService = new();

        public Tickets()
        {
            InitializeComponent();

            // Carrega os chamados e contadores assim que o controle é iniciado
            LoadTickets();
            LoadTicketCounts();
            LoadStatusFilter();
        }
        // Carrega os chamados no DataGridView, podendo aplicar um filtro por status
        private void LoadTickets(string statusFilter = null)
        {
            dgvTickets.Rows.Clear(); // Limpa as linhas do DataGridView

            var tickets = _ticketService.GetTickets(); // Busca todos os chamados

            // Aplica o filtro, se houver
            if (!string.IsNullOrEmpty(statusFilter))
                tickets = tickets.Where(t => t.Status == statusFilter).ToList();

            // Adiciona os chamados ao DataGridView
            foreach (var t in tickets)
            {
                dgvTickets.Rows.Add(
                    t.ChamadoID,
                    t.Status,
                    t.Titulo,
                    t.Prioridade,
                    t.DataAbertura.ToString("dd/MM/yyyy"),
                    t.SolicitanteNome,
                    t.ResponsavelNome ?? ""
                );
            }
            // Atualiza os contadores de status após o carregamento
            LoadTicketCounts();
        }
        // Carrega os chamados filtrando diretamente pelo status informado
        private void LoadTicketsByStatus(string status)
        {
            LoadTickets(status);
        }
        // Atualiza os contadores de chamados por status (indicadores KPI)
        private void LoadTicketCounts()
        {
            NewCount.Text = _ticketService.GetTicketCountByStatus("Aberto").ToString();
            PendingCount.Text = (_ticketService.GetTicketCountByStatus("Pendente")+ _ticketService.GetTicketCountByStatus("Aguardando Aprovação")).ToString();
            AttCount.Text = _ticketService.GetTicketCountByStatus("Atribuído").ToString();
            PlanCount.Text = _ticketService.GetTicketCountByStatus("Planejado").ToString();
            ClosedCount.Text = _ticketService.GetTicketCountByStatus("Fechado").ToString();
        }
        // Evento: clique em uma célula da tabela de chamados
        private void dgvTickets_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return; // Ignora cliques no cabeçalho
            
            // Obtém o ID do chamado da linha clicada
            int ticketId = (int)dgvTickets.Rows[e.RowIndex].Cells["ColID"].Value;

            // Busca o chamado correspondente
            var ticket = _ticketService.GetTickets().FirstOrDefault(t => t.ChamadoID == ticketId);
            if (ticket == null) return;

            // Abre o formulário de detalhes do chamado
            var detailForm = new TicketDetails(ticket);
            detailForm.ShowDialog();
        }

        // Evento: botão de recarregar a lista de chamados
        private void btnReloadList_Click(object sender, EventArgs e)
        {
            LoadTickets(null); // Recarrega todos os chamados
        }

        // Preenche o combobox de filtro com os possíveis status dos chamados
        private void LoadStatusFilter()
        {
            cboStatusFilter.Items.Clear();
            cboStatusFilter.Items.Add("Todos");         
            cboStatusFilter.Items.Add("Aberto");
            cboStatusFilter.Items.Add("Atribuído");
            cboStatusFilter.Items.Add("Aguardando Aprovação");
            cboStatusFilter.Items.Add("Pendente");
            cboStatusFilter.Items.Add("Fechado");
            cboStatusFilter.SelectedIndex = 0;// Define "Todos" como padrão
        }
        // Evento: alteração de filtro no combobox de status
        private void cboStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedStatus = cboStatusFilter.SelectedItem.ToString();

            if (selectedStatus == "Todos")
                LoadTicketsByStatus(null); // Exibe todos os chamados
            else
                LoadTicketsByStatus(selectedStatus); // Exibe apenas os filtrados
        }

    }
}

