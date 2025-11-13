using SistemaChamados.Core.Models;
using SistemaChamados.Core.Services;
using SistemaChamados.Core.Utils;
using SistemaChamadosDesktopOficial.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace SistemaChamadosDesktopOficial.MainApplication
{
    // Formulário responsável por exibir e gerenciar os detalhes de um chamado específico
    public partial class TicketDetails : Form
    {
        // Serviços de apoio utilizados na tela
        private readonly TicketService _ticketService = new();
        private readonly MessageService _messageService = new MessageService();
        private readonly FAQService _faqService = new FAQService();
        // Instância do chamado atual
        private Ticket _ticket;

        public TicketDetails(Ticket ticket)
        {
            InitializeComponent();
            _ticket = ticket;

            LoadTicketInfo();// Carrega as informações básicas do chamado
            LoadMessages();// Carrega o histórico de mensagens

        }
        // Carrega e exibe as informações gerais do chamado na interface
        private void LoadTicketInfo()
        {
            txtTitle.Text = _ticket.Titulo;
            txtDescription.Text = _ticket.Descricao;
            txtStatus.Text = _ticket.Status;
            txtPriority.Text = _ticket.Prioridade;
            txtSolicitante.Text = _ticket.SolicitanteNome;
            txtResponsavel.Text = _ticket.ResponsavelNome ?? "Não atribuído";
            UpdateAssignTicketState(); // Atualiza o estado do botão de atribuição
        }
        // Carrega as mensagens associadas ao chamado
        private void LoadMessages()
        {
            pnlMessages.SuspendLayout(); // Suspende o layout para otimizar a renderização
            try
            {
                pnlMessages.Controls.Clear();

                var messages = _messageService.GetMessagesByTicketId(_ticket.ChamadoID);

                // Cria e adiciona “bubbles” de mensagens na tela
                foreach (var msg in messages)
                {
                    var bubble = new MessageBubble();
                    bubble.SetMessage(msg, msg.CRUDID, msg.IsSolution);
                    pnlMessages.Controls.Add(bubble);
                }
                // Rola até a última mensagem
                if (pnlMessages.Controls.Count > 0)
                {
                    pnlMessages.ScrollControlIntoView(pnlMessages.Controls[pnlMessages.Controls.Count - 1]);
                }

                // Verifica se há solução pendente de aprovação
                var pendingSolution = messages.FirstOrDefault(m => m.IsSolution && m.SolutionPendingApproval);
                bool isTicketOwner = _ticket.SolicitanteID == Session.CurrentUser.UsuarioID;

                // Exibe botões de aprovação/rejeição apenas para o dono do chamado
                if (pendingSolution != null && isTicketOwner)
                {
                    btnApprove.Visible = true;
                    btnReject.Visible = true;
                }
                else
                {
                    btnApprove.Visible = false;
                    btnReject.Visible = false;
                }
            }
            finally
            {
                pnlMessages.ResumeLayout();
            }
        }
        // Envia uma nova mensagem ou proposta de solução
        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            try
            {
                var messageText = txtNewMessage.Text.Trim();
                bool isSolution = chkAddSolution.Checked;

                if (string.IsNullOrWhiteSpace(messageText))
                {
                    MessageBox.Show("Digite uma mensagem antes de enviar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Impede envio se o ticket estiver fechado ou aguardando aprovação
                if (_ticket.Status == "Fechado" || _ticket.Status == "Aguardando Aprovação")
                {
                    MessageBox.Show("Não é possível enviar mensagens para um ticket encerrado ou aguardando aprovação.",
                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Cria a nova mensagem
                var newMessage = new SistemaChamados.Core.Models.Message
                {
                    ChamadoID = _ticket.ChamadoID,
                    UsuarioID = Session.CurrentUser.UsuarioID,
                    UsuarioNome = Session.CurrentUser.Nome,
                    Mensagem = messageText,
                    DataRegistro = DateTime.Now,
                    IsSolution = isSolution
                };

                // Caso seja uma solução, chama o método específico
                if (isSolution)
                {
                    var result = _messageService.AddSolutionMessage(newMessage);
                    if (!result)
                    {
                        MessageBox.Show("Já existe uma solução registrada para este ticket.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Atualiza o status do chamado para "Pendente"
                    _ticket.Status = "Aguardando Aprovação";
                    _ticketService.UpdateTicketStatus(_ticket.ChamadoID, _ticket.Status);
                    MessageBox.Show("Solução proposta! Aguardando aprovação do usuário.");
                }
                else
                {
                    _messageService.AddMessage(newMessage);
                    MessageBox.Show("Mensagem enviada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Atualiza a interface
                txtNewMessage.Clear();
                chkAddSolution.Checked = false;
                LoadMessages();
                LoadTicketInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao enviar mensagem: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Permite que técnicos se atribuam a um chamado
        private void assingTicket_Click(object sender, EventArgs e)
        {
            try
            {
                var currentUser = Session.CurrentUser;

                // Ensure only a technician can assign themselves
                if (currentUser.CRUDID != 2)
                {
                    MessageBox.Show("Apenas técnicos podem se atribuir a chamados.",
                        "Acesso negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _ticketService.AssignTicket(_ticket.ChamadoID, currentUser.UsuarioID);

                MessageBox.Show("Chamado atribuído com sucesso!",
                    "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);


                // Update the current ticket info
                _ticket.ResponsavelID = currentUser.UsuarioID;
                _ticket.ResponsavelNome = currentUser.Nome;
                txtResponsavel.Text = currentUser.Nome;
                txtStatus.Text = "Atribuído";

                UpdateAssignTicketState();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atribuir chamado: {ex.Message}",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Atualiza o estado visual e funcional do botão de atribuição
        private void UpdateAssignTicketState()
        {
            if (_ticket.ResponsavelID != null)
            {
                assingTicket.Enabled = false;
                assingTicket.BackColor = Color.Gray; // Indica bloqueado
            }
            else
            {
                assingTicket.Enabled = true;
                assingTicket.BackColor = Color.LightBlue; // Indica disponível
            }
        }
        // Aprova a solução proposta
        private void btnApprove_Click(object sender, EventArgs e)
        {
            btnApprove.Enabled = false;
            btnReject.Enabled = false;

            var solutionMsg = _messageService.GetPendingSolution(_ticket.ChamadoID);
            if (solutionMsg == null) return;

            // Aprova e fecha o ticket
            _messageService.ApproveSolution(solutionMsg);
            _ticketService.UpdateTicketStatus(_ticket.ChamadoID, "Fechado");

            // Adiciona a solução ao FAQ
            _faqService.AddFAQ(_ticket.ChamadoID, _ticket.Descricao, solutionMsg.Mensagem);

            LoadMessages();
            MessageBox.Show("Solução aprovada e ticket concluído.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        // Rejeita a solução proposta
        private void btnReject_Click(object sender, EventArgs e)
        {
            var solutionMsg = _messageService.GetPendingSolution(_ticket.ChamadoID);
            if (solutionMsg == null) return;

            // Caso a solução seja da IA, reabre o chamado e retira o Agenta IA
            if (_ticket.ResponsavelID == 10)
            {
                _messageService.RejectSolution(solutionMsg);
                _ticketService.UpdateTicketStatus(_ticket.ChamadoID, "Aberto");
            }
            else
            {
                // Caso seja um técnico humano
                _ticketService.UpdateTicketStatus(_ticket.ChamadoID, "Atribuído");
            }

            LoadMessages();
            MessageBox.Show("Solução rejeitada. O ticket permanece aberto.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}