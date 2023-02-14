using BLL;
using Models;

namespace ConsoleAppPrincipal
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            Usuario usuario = new Usuario();
            usuario.Nome = "Erisvaldo Carvalho Silva";
            usuario.NomeUsuario = "erisvaldo";
            usuario.Ativo = true;
            usuario.Email = "contato@erisvaldocarvalho.com.br";
            usuario.CPF = "458.158.442-88";
            usuario.Senha = "123";
            usuarioBLL.Inserir(usuario);
        }
    }
}