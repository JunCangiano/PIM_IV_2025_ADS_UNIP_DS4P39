using SistemaChamados.Core.Models;
using SistemaChamados.Core.Repositories;
using SistemaChamados.Core.Utils;
using System;

namespace SistemaChamados.Core.Services
{
    public class LoginService
    {
        // Repositório responsável por acessar os dados dos usuários no banco.
        private readonly UserRepository _usuarioRepository = new();
        // Realiza a autenticação de um usuário com base em e-mail e senha.
        public User Authenticate(string email, string password)
        {
            // Busca o usuário pelo e-mail informado.
            var user = _usuarioRepository.GetByEmail(email);
            if (user == null)
                throw new Exception("Usuário não encontrado.");

            // Verifica se a senha informada corresponde ao hash armazenado.
            if (!PasswordHasher.Verify(password, user.SenhaHash))
                throw new Exception("Senha incorreta.");

            // Obtém o papel (função) do usuário no sistema e atribui ao objeto.
            user.CRUDID = _usuarioRepository.GetUserRole(user.UsuarioID);

            // Retorna o usuário autenticado com suas informações atualizadas.
            return user;
        }
    }
}
