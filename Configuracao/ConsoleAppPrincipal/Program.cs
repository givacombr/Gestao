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
                    Console.WriteLine("1 - Cadastrar Usuario");
                    Console.WriteLine("2 - Cadastrar Grupo");
                    Console.WriteLine("3 - Cadastrar Permissão");
                    Console.WriteLine("4 - Alterar Usuario");
                    Console.WriteLine("5 - Alterar Grupo");
                    Console.WriteLine("6 - Alterar Permissão");
                    Console.WriteLine("7 - Buscar Usuario");
                    Console.WriteLine("8 - Buscar Grupo");
                    Console.WriteLine("9 - Buscar Permissao");
                    Console.WriteLine("10 - Excluir Usuario");
                    Console.WriteLine("11 - Excluir Grupo");
                    Console.WriteLine("12 - Excluir Permissao");
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
                        case 3:
                            CadastrarPermissao();
                            break;
                        case 4:
                            AlterarUsuario();
                            break;
                        case 5:
                            AlterarGrupo();
                            break;
                        case 6:
                            AlterarPermissao();
                            break;
                        case 7:
                            //BuscarUsuario();
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

        private static void AlterarPermissao()
        {
            int sn;
            Permissao permissao = new Permissao();
            PermissaoBLL permissaoBLL = new PermissaoBLL();
            Console.Clear();

            do
            {
                Console.WriteLine("\nAltera Permissão\n\n");
                Console.WriteLine("Qual a Permissão que deseja alterar: ");
                permissao.Descricao = Console.ReadLine();
                permissaoBLL.Alterar(permissao);
                Console.WriteLine("Permissão alterada com sucesso.\n\nDeseja alterar uma nova Permissão: [1] Sim [2] Nao ");
                sn = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            } while (sn != 2);
        }

        private static void AlterarGrupo()
        {
            int sn;
            GrupoUsuario grupoUsuario = new GrupoUsuario();
            GrupoUsuarioBLL grupoUsuarioBLL = new GrupoUsuarioBLL();
            Console.Clear();

            do
            {
                Console.WriteLine("\nAlterar Grupo\n\n");
                Console.WriteLine("Altere o nome do grupo: ");
                grupoUsuario.NomeGrupo = Console.ReadLine();
                //Console.Clear();
                grupoUsuarioBLL.Alterar(grupoUsuario);
                Console.WriteLine("Grupo alterado com sucesso.\n\nDeseja alterar um outro grupo: [1] Sim [2] Nao ");
                sn = Convert.ToInt32(Console.ReadLine());
            } while (sn != 2);
        }
        private static void AlterarUsuario()
        {
            int sn;
            Usuario usuario = new Usuario();
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            Console.Clear();

            do
            {
                Console.WriteLine("\nAlteração de Cadastro\n\n");
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
                Console.WriteLine("Alteração de cadastrado com sucesso.\n\nDeseja alterar um novo usuário: [1] Sim [2] Não ");
                sn = Convert.ToInt32(Console.ReadLine());
            } while (sn != 2);
        }
        private static void CadastrarPermissao()
        {
            int sn;
            Permissao permissao = new Permissao();
            PermissaoBLL permissaoBLL = new PermissaoBLL();
            Console.Clear();

            do
            {
                Console.WriteLine("\nCria Permissão\n\n");
                Console.WriteLine("Insira o nome da Permissão: ");
                permissao.Descricao = Console.ReadLine();
                permissaoBLL.Inserir(permissao);
                Console.WriteLine("Permissão criado com sucesso.\n\nDeseja criar uma nova Permissão: [1] Sim [2] Nao ");
                sn = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            } while (sn != 2);
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