using BLL;
using DAL;
using Models;

namespace ConsoleAppPrincipal
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                int prog;
                do
                {
                    Console.Clear();
                    Console.Title = "MENU";
                    Console.WriteLine("\tMENU");
                    Console.WriteLine("Escolha uma opção: ");
                    Console.WriteLine("1 - Cadastrar Usuario");//Console.WriteLine("Escolha uma opção:\n\1 - Cadastrar usuário\n\2 - ");
                    Console.WriteLine("2 - Cadastrar Grupo");
                    Console.WriteLine("3 - Buscar");
                    Console.WriteLine("4 - Alterar");
                    Console.WriteLine("5 - Excluir");
                    Console.WriteLine("0 - Sair");
                    prog = Convert.ToInt32(Console.ReadLine());

                    switch (prog)
                    {
                        case 1:
                            CadastrarUsuario();
                            break;
                        case 2:
                            CadastrarGrupo();
                            break;

                        default:
                            break;
                    }
                } while (prog != 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private static void CadastrarGrupo()
        {
            int sn;
            GrupoUsuario grupoUsuario = new GrupoUsuario();
            GrupoUsuarioBLL grupoUsuarioBLL = new GrupoUsuarioBLL();
            Console.Clear();

            do
            {
                Console.WriteLine("\nCria Grupo\n\n");
                Console.WriteLine("Insira o nome do grupo: ");
                grupoUsuario.NomeGrupo = Console.ReadLine();
                //Console.Clear();
                grupoUsuarioBLL.Inserir(grupoUsuario);
                Console.WriteLine("Grupo criado com sucesso.\n\nDeseja criar um novo grupo: [1] Sim [2] Nao ");
                sn = Convert.ToInt32(Console.ReadLine());
            } while (sn != 2);
        }

        private static void CadastrarUsuario()
        {
            int sn;
            Usuario usuario = new Usuario();
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            Console.Clear();

            do
            {
                Console.WriteLine("\nSistema de Cadastro\n\n");
                Console.WriteLine("Informe seu Nome Completo: ");
                usuario.Nome = Console.ReadLine();
                Console.WriteLine("Informe o nome de acesso do Usuário: ");
                usuario.NomeUsuario = Console.ReadLine();
                Console.WriteLine("Informe seu Email: ");
                usuario.Email = Console.ReadLine();
                Console.WriteLine("Informe o seu CPF: ");
                usuario.CPF = Console.ReadLine();
                Console.WriteLine("Cadastre sua Senha: ");
                usuario.Senha = Console.ReadLine();
                Console.WriteLine("O usuário estará ativo (S) ou (N)");
                usuario.Ativo = Console.ReadLine().ToLower() == "s";//armazendo expressao booleana

                Console.Clear();

                usuarioBLL.Inserir(usuario);
                Console.WriteLine("Usuário cadastrado com sucesso.\n\nDeseja cadastrar um novo usuário: [1] Sim [2] Não ");
                sn = Convert.ToInt32(Console.ReadLine());
            } while (sn != 2);
        }
    }
}