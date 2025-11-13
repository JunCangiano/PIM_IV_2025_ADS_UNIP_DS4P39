using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using SistemaChamados.Core.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SistemaChamadosDesktopOficial.MainApplication
{
    public partial class HomePage : UserControl
    {
        private readonly TicketService _ticketService = new();// Serviço para acessar dados de tickets
        
        public HomePage()
        {
            InitializeComponent();
            LoadTickets();
        }
        // Carrega a lista de tickets, podendo filtrar por status.
        // name="statusFilter"> Se informado, retorna apenas tickets com este status
        private void LoadTickets(string statusFilter = null)
        {
            var tickets = _ticketService.GetTickets(); // Obtém todos os tickets do sistema

            // Filtra tickets caso um status específico seja informado
            if (!string.IsNullOrEmpty(statusFilter))
                tickets = tickets.Where(t => t.Status == statusFilter).ToList();

            // Atualiza contadores de KPI na tela após aplicar filtro
            LoadTicketCounts();
        }

        // Atualiza os contadores de tickets por status na tela inicial.
        private void LoadTicketCounts()
        {
            NewCount.Text = _ticketService.GetTicketCountByStatus("Aberto").ToString();
            PendingCount.Text = (_ticketService.GetTicketCountByStatus("Pendente") + _ticketService.GetTicketCountByStatus("Aguardando Aprovação")).ToString();
            AttCount.Text = _ticketService.GetTicketCountByStatus("Atribuído").ToString();
            PlanCount.Text = _ticketService.GetTicketCountByStatus("Planejado").ToString();
            ClosedCount.Text = _ticketService.GetTicketCountByStatus("Fechado").ToString();
        }
    }
}
