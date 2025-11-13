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

namespace SistemaChamadosDesktopOficial.MainApplication
{
    public partial class Calendar : UserControl
    {
        private readonly TicketService _ticketService = new(); // Serviço para acessar tickets
        private List<Ticket> _tickets;                         // Lista de tickets carregados

        public Calendar()
        {
            InitializeComponent();
            LoadTickets();
        }
        // Carrega tickets e destaca datas no calendário.
        private void LoadTickets(string statusFilter = null)
        {
            _tickets = _ticketService.GetTickets(); // Recupera todos os tickets

            if (!string.IsNullOrEmpty(statusFilter))
                _tickets = _tickets.Where(t => t.Status == statusFilter).ToList();

            // Limpa datas destacadas e adiciona datas dos tickets
            plannedTickets.RemoveAllBoldedDates();
            foreach (var ticket in _tickets)
                plannedTickets.AddBoldedDate(ticket.DataAbertura.Date);

            plannedTickets.UpdateBoldedDates(); // Atualiza visualmente o calendário

            LoadTicketCounts(); // Atualiza os contadores de status
        }
        // Atualiza os contadores de tickets por status.
        private void LoadTicketCounts()
        {
            NewCount.Text = _ticketService.GetTicketCountByStatus("Aberto").ToString();
            PendingCount.Text = (_ticketService.GetTicketCountByStatus("Pendente") + _ticketService.GetTicketCountByStatus("Aguardando Aprovação")).ToString();
            AttCount.Text = _ticketService.GetTicketCountByStatus("Atribuído").ToString();
            PlanCount.Text = _ticketService.GetTicketCountByStatus("Planejado").ToString();
            ClosedCount.Text = _ticketService.GetTicketCountByStatus("Fechado").ToString();
        }
        // Ao selecionar uma data no calendário, mostra tickets do dia.
        private void plannedTickets_DateSelected(object sender, DateRangeEventArgs e)
        {
            var selectedDate = e.Start.Date;

            var ticketsForDay = _tickets
                .Where(t => t.DataAbertura.Date == selectedDate)
                .ToList();

            listTickets.Items.Clear();

            foreach (var t in ticketsForDay)
            {
                var item = new ListViewItem(t.Titulo);
                item.SubItems.Add(t.Status);
                item.Tag = t;// Armazena o objeto completo do ticket para uso posterior

                // Define cor do item com base no status do ticket
                item.BackColor = GetColorByStatus(t.Status);
                listTickets.Items.Add(item);
            }
        }
        // Retorna uma cor de acordo com o status do ticket.
        private Color GetColorByStatus(string status) => status switch
        {
            "Aberto" => Color.LightCoral,
            "Pendente" => Color.Khaki,
            "Fechado" => Color.LightGreen,
            _ => Color.White
        };
        // Ao dar duplo clique em um ticket da lista, abre detalhes.
        private void listTickets_DoubleClick(object sender, EventArgs e)
        {
            if (listTickets.SelectedItems.Count == 0) return;

            var selectedTicket = (Ticket)listTickets.SelectedItems[0].Tag;
            var detailsForm = new TicketDetails(selectedTicket);
            detailsForm.ShowDialog();
        }
        // Recarrega todos os tickets e atualiza calendário e lista.
        private void btnReloadList_Click(object sender, EventArgs e)
        {
            LoadTickets();
        }
    }
}
