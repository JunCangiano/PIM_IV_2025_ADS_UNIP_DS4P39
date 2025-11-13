using SistemaChamados.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaChamados.Core.Models;


namespace SistemaChamados.Core.Services
{
    public class FAQService
    {
        private readonly FAQRepository _faqRepo = new();
        // Adiciona uma nova FAQ a partir de um chamado existente.
        public void AddFAQ(int sourceChamadoId, string question, string answer)
        {
            _faqRepo.InsertFAQ(sourceChamadoId, question, answer);
        }
        // Retorna a lista de FAQs para exibição; se 'adminView' for falso, exibe apenas as aprovadas.
        public List<Faq> GetFaqsForDisplay(bool adminView = false)
        {
            return _faqRepo.GetAll(!adminView);
        }
        // Retorna solicitações mais acessadas.
        public List<Faq> GetTopFaqs()
        {
            return _faqRepo.GetTopFaqs();
        }
        // Define o status de aprovação de uma FAQ.
        public void ApproveFaq(int faqId, bool approved)
        {
            _faqRepo.SetApproval(faqId, approved);
        }
        // Incrementa o contador de visualizações de uma FAQ.
        public void IncrementFaqView(int faqId)
        {
            _faqRepo.IncrementVisualizacao(faqId);
        }
    }
}
