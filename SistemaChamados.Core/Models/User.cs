using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaChamados.Core.Models
{
    //Representa um usuário do sistema (administrador, técnico ou colaborador).
    public class User
    {
        // Identificador único do usuário.
        public int UsuarioID { get; set; }

        // Nome completo do usuário.
        public string Nome { get; set; } = string.Empty;

        // E-mail utilizado para login e comunicação.
        public string Email { get; set; } = string.Empty;

        // Senha armazenada em formato criptografado (hash).
        public string SenhaHash { get; set; } = string.Empty;

        // Telefone para contato (opcional).
        public string? Telefone { get; set; }

        // Define se o usuário está ativo no sistema.
        public bool Ativo { get; set; }

        // Chave estrangeira referente ao nível de acesso (tabela CRUD).
        public int CRUDID { get; set; }

        // Chave estrangeira opcional para associação a um departamento.
        public int? DepartamentoID { get; set; }

        // Nome do departamento associado (campo auxiliar).
        public string DepartamentoNome { get; set; } = string.Empty;

        // Indica se o usuário aceitou os termos de uso e privacidade.
        public bool AceitouTermos { get; set; }
    }
}