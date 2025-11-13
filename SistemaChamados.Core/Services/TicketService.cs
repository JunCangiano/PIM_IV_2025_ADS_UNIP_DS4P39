using Microsoft.Data.SqlClient;
using SistemaChamados.Core.Data;
using SistemaChamados.Core.Models;
using SistemaChamados.Core.Repositories;
using System.Collections.Generic;
using System.Data;

namespace SistemaChamados.Core.Services
{
    public class TicketService
    {
        // Repositório principal responsável pelas operações de chamados.
        private readonly TicketRepository _repository = new();
        // Repositório responsável pelas mensagens relacionadas aos chamados.
        private readonly MessageRepository _historyRepo = new();

        // Retorna todos os chamados cadastrados.
        public List<Ticket> GetTickets() => _repository.GetTickets();
        // Cria um novo chamado no sistema.
        public void CreateTicket(Ticket ticket)
        {
            // Validação dos campos obrigatórios.
            ValidateTicket(ticket);
            // Salva o chamado no banco e obtém o ID gerado.
            int chamadoId = _repository.AddTicket(ticket);
            ticket.ChamadoID = chamadoId;
            // Gera uma resposta automática através da IA.
            var aiService = new AIService();
            string aiResponse = aiService.GenerateSolution(ticket);
            // Atribui o chamado ao agente de IA (ID = 10).
            _repository.AssignTicket(chamadoId, 10);
            // Registra a mensagem gerada pela IA como solução pendente.
            var aiMessage = new Message
            {
                ChamadoID = chamadoId,
                UsuarioID = 10, // Agente IA
                Mensagem = aiResponse,
                DataRegistro = DateTime.Now,
                IsSolution = true
            };

            _historyRepo.AddSolutionMessage(aiMessage);

            Console.WriteLine($"Chamado {chamadoId}: solução gerada pela IA e atribuída ao Agente IA.");
        }
        // Valida os dados essenciais de um chamado antes de inseri-lo no banco.
        public void ValidateTicket(Ticket ticket)
        {
            if (string.IsNullOrWhiteSpace(ticket.Titulo))
                throw new Exception("O título não pode estar vazio.");

            if (string.IsNullOrWhiteSpace(ticket.Descricao))
                throw new Exception("A descrição não pode estar vazia.");

            if (ticket.SolicitanteID == 0)
                throw new Exception("Solicitante inválido.");

            if (ticket.DepartamentoID == 0)
                throw new Exception("Selecione uma categoria.");

            // Caso a prioridade não seja informada, define como "Média".
            if (string.IsNullOrWhiteSpace(ticket.Prioridade))
                ticket.Prioridade = "Média";
        }
        // Retorna a quantidade de chamados de acordo com o status informado.
        public int GetTicketCountByStatus(string status)
        {
            return _repository.GetTicketCountByStatus(status);
        }
        // Retorna as mensagens associadas a um determinado chamado.
        public List<Message> GetMessages(int ticketId) => _historyRepo.GetMessagesByTicketId(ticketId);
        // Envia uma nova mensagem dentro de um chamado.
        public void SendMessage(Message message)
        {
            if (string.IsNullOrWhiteSpace(message.Mensagem))
                throw new Exception("Mensagem vazia não é permitida.");

            _historyRepo.AddMessage(message);
        }
        // Atribui um chamado a um técnico específico.
        public void AssignTicket(int ticketId, int technicianId)
        {
            var tickets = _repository.GetTickets();
            var ticket = tickets.FirstOrDefault(t => t.ChamadoID == ticketId);

            if (ticket == null)
                throw new Exception("Chamado não encontrado.");

            if (ticket.ResponsavelID != null)
                throw new Exception("Este chamado já está atribuído a outro técnico.");

            _repository.AssignTicket(ticketId, technicianId);
        }
        // Atualiza o status de um chamado (por exemplo, "Aberto", "Em andamento", "Fechado").
        public void UpdateTicketStatus(int chamadoId, string status)
        {
            _repository.UpdateTicketStatus(chamadoId, status);
        }
        // Retorna um chamado específico pelo seu ID.
        public Ticket GetTicketById(int ticketId)
        {
            return _repository.GetTicketById(ticketId);
        }
        // Relatórios e estatísticas para dashboards administrativos:
        public DataTable GetTicketsByStatus() => _repository.GetTicketsByStatus();
        public DataTable GetTicketsByPriority() => _repository.GetTicketsByPriority();
        public DataTable GetTicketsOpenedPerDay(int days = 30) => _repository.GetTicketsOpenedPerDay(days);
        public DataTable GetTicketsByTechnician() => _repository.GetTicketsByTechnician();
    }
}
