using System.Security.Cryptography;
using System.Text;

namespace SistemaChamados.Core.Utils
{
    public static class PasswordHasher
    {
        // Gera um hash SHA-256 a partir da senha informada.
        public static string Hash(string password)
        {
            using (SHA256 sha = SHA256.Create())
            {
                // Converte a senha em bytes e aplica o algoritmo de hash.
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
                // Converte o resultado em string hexadecimal minúscula.
                return BitConverter.ToString(bytes).Replace("-", "").ToLower();
            }
        }
        // Verifica se a senha informada gera o mesmo hash armazenado.
        public static bool Verify(string inputPassword, string storedHash)
        {
            return Hash(inputPassword) == storedHash;
        }
    }
}
