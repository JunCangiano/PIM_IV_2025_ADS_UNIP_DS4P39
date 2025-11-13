using OpenAI;
using OpenAI.Chat;
using SistemaChamados.Core.Models;
using SistemaChamados.Core.Services;
using System;
using System.Threading.Tasks;

public class AIService
{
    // Chave de API do OpenAI
    private readonly string _apiKey = "sk-your-api-key-here";
    // Instância do serviço de FAQ para consulta à base de conhecimento
    private readonly FAQService _faqService = new FAQService();

    // Gera uma resposta automática (solução) para um chamado usando o modelo de IA (OpenAI).
    // Caso ocorra erro ou falha na requisição, retorna uma resposta padrão.
    public string GenerateSolution(Ticket ticket)
    {
        try
        {
            // Inicializa o cliente de Chat da OpenAI
            var client = new ChatClient(
                model: "gpt-4.1-mini",
                apiKey: _apiKey
            );

            // Constrói a conversa com o modelo
            // Inclui mensagens de sistema (instruções) e do usuário (descrição do chamado)
            var messages = new List<ChatMessage>
            {
                new SystemChatMessage(@$"
                Instruções de comportamento:
                - Seja educado, profissional e use uma linguagem neutra e inclusiva.
                - Forneça respostas objetivas, claras e técnicas.
                - Nunca discrimine, julgue ou faça suposições sobre o usuário.
                - Caso não haja base suficiente, diga que não possui dados suficientes.
                - Use sempre português formal e neutro, evitando gírias.
                - Não cite a IA ou OpenAI, você é parte da equipe de suporte.
                - Use informações semelhantes na base de conhecimento (FAQ).
                - Não repita a pergunta do usuário na resposta.
                - Limite-se a uma única resposta direta.

                Dados do chamado atual:
                ID do chamado: {ticket.ChamadoID}
                Título: {ticket.Titulo}
                Prioridade: {ticket.Prioridade}
                Departamento: {ticket.DepartamentoNome}
                Solicitante: {ticket.SolicitanteNome}

                Base de conhecimento (FAQ):
                {_faqService.GetTopFaqs}

                Objetivo:
                Com base nas informações acima, redija uma possível resposta técnica ao chamado, sugerindo uma solução apropriada. Responda APENAS com o texto da mensagem que será enviada ao usuário.
                "),
                // Mensagem do usuário simulando a descrição do chamado
                new UserChatMessage($"Descrição do chamado: {ticket.Descricao}")
            };

            // Envia o prompt ao modelo e obtém a conclusão
            ChatCompletion completion = client.CompleteChat(messages);

            // Extrai o texto da resposta gerada pela IA
            string aiMessage = completion?.Content?[0]?.Text?.Trim();

            // Caso retorne vazio ou nulo, usa uma resposta de padrão
            return string.IsNullOrWhiteSpace(aiMessage) ?
                $"Olá! Aqui está uma possível solução automática gerada pelo sistema:\n\n" +
                $"Com base na sua descrição: \"{ticket.Descricao}\", sugerimos verificar as configurações " +
                $"relacionadas ou reiniciar o serviço envolvido.\n\n" +
                $"Caso o problema persista, um técnico irá analisar sua solicitação."
                : aiMessage;
        }
        catch (Exception ex)
        {
            // Captura falhas na requisição ou erros de API
            Console.WriteLine($"[AIService] Erro ao gerar solução: {ex.Message}");
            return // Retorna a resposta padrão segura
                $"Olá! Aqui está uma possível solução automática gerada pelo sistema:\n\n" +
                $"Com base na sua descrição: \"{ticket.Descricao}\", sugerimos verificar as configurações " +
                $"relacionadas ou reiniciar o serviço envolvido.\n\n" +
                $"Caso o problema persista, um técnico irá analisar sua solicitação.";
        }
    }
}
