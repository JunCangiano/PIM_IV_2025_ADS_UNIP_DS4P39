using SistemaChamados.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaChamados.Core.Utils
{
    // Classe estática responsável por gerenciar a sessão do usuário logado no sistema.
    public static class Session
    {
        // Armazena o usuário atualmente autenticado.
        public static User CurrentUser { get; set; }
        // Inicia a sessão, definindo o usuário logado.
        public static void Start(User user)
        {
            CurrentUser = user;
        }
        // Encerra a sessão, removendo o usuário atual.
        public static void End()
        {
            CurrentUser = null;
        }
        // Propriedade que indica se há um usuário logado.
        public static bool IsLoggedIn => CurrentUser != null;
    }
}
