using BLL;
using Models;

namespace ConsoleAppPrincipal
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                Usuario usuario = new Usuario();
                UsuarioBLL usuarioBLL = new UsuarioBLL();

                usuario.Nome = "Erisvaldo Carvalho Silva";
                usuario.NomeUsuario = "erisvaldo";
                usuario.Ativo = true;
                usuario.Email = "contato@erisvaldocarvalho.com.br";
                usuario.CPF = "458.158.442-88";
                usuario.Senha = "504587545";

                usuarioBLL.Inserir(usuario);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}