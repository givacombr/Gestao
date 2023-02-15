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
                int sn;

                Usuario usuario = new Usuario();
                UsuarioBLL usuarioBLL = new UsuarioBLL();

                Console.WriteLine("Deseja cadastrar um novo usuário: [1] Sim [2] Não ");
                sn = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                while (sn != 2)
                {
                    Console.WriteLine("\nSistema de Cadastro\n\n");
                    Console.WriteLine("Informe seu Nome Completo: ");
                    usuario.Nome = Console.ReadLine();
                    Console.WriteLine("Informe o nome de acesso do Usuário: ");
                    usuario.NomeUsuario = Console.ReadLine();
                    usuario.Ativo = true;
                    Console.WriteLine("Informe seu Email: ");
                    usuario.Email = Console.ReadLine();
                    Console.WriteLine("Informe o seu CPF: ");
                    usuario.CPF = Console.ReadLine();
                    Console.WriteLine("Cadastre sua Senha: ");
                    usuario.Senha = Console.ReadLine();

                    usuarioBLL.Inserir(usuario);
                    Console.WriteLine("Deseja cadastrar um novo usuário: [1] Sim [2] Não ");
                    sn = Convert.ToInt32(Console.ReadLine());
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}