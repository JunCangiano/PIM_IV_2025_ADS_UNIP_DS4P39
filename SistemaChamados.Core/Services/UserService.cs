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
    public class UserService
    {
        // Repositórios responsáveis por usuários e departamentos.
        private readonly UserRepository _userRepository = new();
        private readonly DepartamentoRepository _departamentoRepository = new();
        // Retorna todos os usuários cadastrados.
        public List<User> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
        }
        // Busca um usuário pelo e-mail.
        public User? GetUserByEmail(string email)
        {
            return _userRepository.GetByEmail(email);
        }
        // Retorna o papel (nível de permissão) do usuário pelo ID.
        public int GetUserRole(int usuarioId)
        {
            return _userRepository.GetUserRole(usuarioId);
        }
        // Retorna a lista de departamentos cadastrados.
        public List<Department> GetDepartments()
        {
            return _departamentoRepository.GetAll();
        }
        // Atualiza as informações de um usuário existente.
        public void UpdateUser(User updatedUser)
        {
            var currentUser = Session.CurrentUser;
            // Se o usuário estiver atualizando o próprio perfil, mantém ativo e preserva o nível de permissão atual.
            if (currentUser != null && currentUser.UsuarioID == updatedUser.UsuarioID)
            {
                updatedUser.Ativo = true;
                updatedUser.CRUDID = currentUser.CRUDID;
            }

            _userRepository.UpdateUser(updatedUser);
        }
        // Cria um novo usuário com valores padrão, caso não informados.
        public void CreateUser(User user)
        {
            // Define como colaborador se o nível de permissão não for informado.
            if (user.CRUDID <= 0)
                user.CRUDID = 3;

            // Define uma senha padrão criptografada se nenhuma for definida.
            if (string.IsNullOrWhiteSpace(user.SenhaHash))
                user.SenhaHash = PasswordHasher.Hash("123456");

            _userRepository.CreateUser(user);
        }
        // Verifica se já existe um usuário com o e-mail informado.
        public bool EmailExists(string email)
        {
            var users = _userRepository.GetAllUsers();
            return users.Any(u => u.Email.Equals(email, StringComparison.OrdinalIgnoreCase));
        }
        // Redefine a senha de um usuário e salva a nova versão criptografada.
        public void ResetPassword(int userId, string plainPassword)
        {
            string hashed = PasswordHasher.Hash(plainPassword);
            _userRepository.ResetPassword(userId, hashed);
        }
        // Anonimiza um usuário (LGPD) — substitui seus dados por valores genéricos.
        public void AnonymizeUser(string userEmail)
        {
            var user = GetUserByEmail(userEmail);
            if (user == null) return;

            user.Nome = "Anônimo_" + Guid.NewGuid().ToString("N").Substring(0, 8);
            user.Email = "anon_" + Guid.NewGuid().ToString("N").Substring(0, 8) + "@example.com";
            user.SenhaHash = Guid.NewGuid().ToString("N").Substring(0, 12); // hash aleatório irreversível
            user.Ativo = false;
            user.DepartamentoID = null; 
            user.CRUDID = 3; // redefine como colaborador

            _userRepository.UpdateUser(user);
        }

    }

}
