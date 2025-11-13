using Microsoft.Data.SqlClient;
using SistemaChamados.Core.Data;
using SistemaChamados.Core.Models;
using SistemaChamados.Core.Repositories;
using SistemaChamados.Core.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaChamados.Core.Services
{
    public class MessageService
    {
        // Repositório responsável pelas operações de mensagens no banco.
        private readonly MessageRepository _repository = new MessageRepository();
        // Repositório para acessar dados dos chamados.
        private readonly TicketRepository _ticketRepository = new();
        // Serviço de FAQ para registrar soluções aprovadas.
        private readonly FAQService _faqService = new();

        // Retorna todas as mensagens relacionadas a um chamado específico.
        public List<Message> GetMessagesByTicketId(int ticketId)
        {
            return _repository.GetMessagesByTicketId(ticketId);
        }
        // Adiciona uma nova mensagem ao chamado, validando o conteúdo.
        public void AddMessage(Message message)
        {
            if (string.IsNullOrWhiteSpace(message.Mensagem))
                throw new ArgumentException("Mensagem não pode estar vazia.");

            _repository.AddMessage(message);
        }
        // Adiciona uma mensagem marcada como solução para o chamado.
        public bool AddSolutionMessage(Message message)
        {
            if (string.IsNullOrWhiteSpace(message.Mensagem))
                throw new ArgumentException("Mensagem não pode estar vazia.");
            // Restringe envio de soluções a técnicos ou administradores.
            if (Session.CurrentUser.CRUDID == 3)
                throw new Exception("Colaborador não pode enviar soluções.");
            // Busca informações do chamado.
            var ticket = _ticketRepository.GetTicketById(message.ChamadoID);
            // Garante que o chamado já tenha um técnico responsável.
            if (ticket.ResponsavelID == null)
                throw new Exception("O ticket precisa ser atribuído a um técnico antes de interagir.");
            // Impede que o próprio solicitante envie soluções.
            if (Session.CurrentUser.UsuarioID == ticket.SolicitanteID)
                throw new Exception("Você não pode atribuir o ticket a si mesmo.");
            // Executa a operação no repositório. 
            return _repository.AddSolutionMessage(message);
        }
        // Aprova uma solução enviada, confirmando sua validade.
        public void ApproveSolution(Message message)
        {
            _repository.MarkSolutionApproved(message.HistoricoID);
        }
        // Rejeita uma solução pendente, revertendo o status.
        public void RejectSolution(Message solutionMessage)
        {
            if (!solutionMessage.IsSolution || !solutionMessage.SolutionPendingApproval)
                throw new Exception("Essa mensagem não é uma solução pendente.");
            // Marca a solução como rejeitada no banco.
            _repository.MarkSolutionRejected(solutionMessage.HistoricoID);
            // Se o responsável for o agente de IA, remove sua atribuição do chamado.
            var ticket = _ticketRepository.GetTicketById(solutionMessage.ChamadoID);
            if (ticket != null && ticket.ResponsavelID == 10)
            {
                _ticketRepository.UnassignTicket(ticket.ChamadoID);
            }
        }
        // Retorna a solução pendente de aprovação associada a um chamado.
        public Message GetPendingSolution(int chamadoId)
        {
            return _repository.GetMessagesByTicketId(chamadoId)
                .FirstOrDefault(m => m.IsSolution && m.SolutionPendingApproval);
        }
    }
}
