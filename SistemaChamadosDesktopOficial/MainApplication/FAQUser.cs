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
    public partial class FAQUser : UserControl
    {
        private readonly FAQService _faqService = new();       // Serviço para gerenciar FAQs
        private readonly TicketService _ticketService = new(); // Serviço para acessar tickets
        private Faq _selectedFaq;                              // FAQ atualmente selecionado na lista

        public FAQUser()
        {
            InitializeComponent();
            LoadTopFaqs();
        }
        // Carrega FAQs mais populares na lista lateral.
        private void LoadTopFaqs()
        {
            var topFaqs = _faqService.GetTopFaqs();
            lstTopFaqs.DataSource = topFaqs;
            lstTopFaqs.DisplayMember = "Pergunta";
            lstTopFaqs.ValueMember = "FaqID";
        }
        // Exibe detalhes da FAQ selecionada ao dar duplo clique na lista.
        private void lstTopFaqs_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lstTopFaqs.SelectedItem is Faq selected)
            {
                txtPergunta.Text = selected.Pergunta; // Mostra pergunta no TextBox
                txtResposta.Text = selected.Resposta; // Mostra resposta no TextBox
                _faqService.IncrementFaqView(selected.FaqID); // Incrementa contador de visualizações
                _selectedFaq = selected;
            }
        }
        // Abre o ticket original vinculado a uma FAQ, se existir.
        private void btnOpenTicket_Click(object sender, EventArgs e)
        {
            if (_selectedFaq == null)
            {
                MessageBox.Show("Selecione uma pergunta primeiro.");
                return;
            }

            int ticketId = _selectedFaq.FonteChamadoID;
            if (ticketId <= 0)
            {
                MessageBox.Show("Este FAQ não está vinculado a um chamado.");
                return;
            }

            var ticket = _ticketService.GetTicketById(ticketId);
            if (ticket == null)
            {
                MessageBox.Show("Chamado original não encontrado. Ele pode ter sido removido.");
                return;
            }
            // Abre o formulário de detalhes do ticket vinculado
            var ticketDetailsForm = new TicketDetails(ticket);
            ticketDetailsForm.ShowDialog();
        }
    }
}
