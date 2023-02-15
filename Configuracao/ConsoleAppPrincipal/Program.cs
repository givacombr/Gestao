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

                Console.WriteLine("Deseja cadastrar um novo usuário: Digite [1] Sim [2] Não ");
                sn = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                while (sn != 2)
                {
                    Console.WriteLine("\n#### Sistema de Cadastro ####\n\n");
                    Console.WriteLine("Digite seu nome completo: ");
                    usuario.Nome = Console.ReadLine();
                    Console.WriteLine("Digite um nome para o acesso: ");
                    usuario.NomeUsuario = Console.ReadLine();
                    Console.WriteLine("Digite um Email válido: ");
                    usuario.Email = Console.ReadLine();
                    Console.WriteLine("Digite o seu CPF: ");
                    usuario.CPF = Console.ReadLine();
                    Console.WriteLine("Cadastre sua senha: ");
                    usuario.Senha = Console.ReadLine();
                    usuario.Ativo = true;

                    usuarioBLL.Inserir(usuario);
                    Console.WriteLine("Deseja cadastrar um novo usuário: Digite [1] Sim [2] Não ");
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