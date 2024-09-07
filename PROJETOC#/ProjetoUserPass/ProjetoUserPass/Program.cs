using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProjetoUserPass
{
    internal class Program
    {
        static string strConexao = "server=localhost;database=bduserpass;uid=root;pwd=123456";
        static MySqlConnection conexao;

        static void Main(string[] args)
        {
            bool sairMenu = false;
            int codigoMenu = 0;

            while (!sairMenu)
            {
                Console.WriteLine("============MENU============");
                Console.WriteLine(criarMenu());
                Console.WriteLine("============================");
                try
                {
                    codigoMenu = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ocorreu um erro:\n" + e.Message);
                }

                switch (codigoMenu)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("============================");
                        Console.WriteLine("LISTAR USUÁRIOS");
                        listarUsuarios();
                        Console.WriteLine("============================");
                        aguardarSair();
                        codigoMenu = 0;
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("============================");
                        Console.WriteLine("ADICIONAR NOVO USUÁRIO");
                        adicionarUsuario();
                        Console.WriteLine("============================");
                        aguardarSair();
                        codigoMenu = 0;
                        break;

                    case 9: 
                        Console.Clear();
                        sairMenu = true;
                        break;

                    default:
                        Console.Clear();
                        break;
                }
            }
            

        }

        static string criarMenu()
        {
            string menu = "(1) - LISTAR USUÁRIOS";
            menu += "\n(2) - ADICIONAR NOVO USUÁRIO";
            menu += "\n(9) - SAIR";

            return menu;
        }

        static void listarUsuarios()
        {
            try
            {
                conexao = new MySqlConnection(strConexao);
                conexao.Open();

                var strComando = new MySqlCommand(
                    "SELECT * FROM tbusuarios", conexao);

                var resultado = strComando.ExecuteReader();

                while (resultado.Read())
                {
                    Console.WriteLine($"{resultado["id"]} - {resultado["nome"]} - {resultado["email"]}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        static void adicionarUsuario()
        {
            try
            {
                conexao = new MySqlConnection(strConexao);
                conexao.Open();

                Console.WriteLine("Digite o nome do novo usuário:");
                string nome = Console.ReadLine();

                Console.WriteLine("Digite um email para o novo usuário:");
                string email = Console.ReadLine();

                Console.WriteLine("Crie uma senha para o novo usuário:");
                string senha = Console.ReadLine();


                var strComando = new MySqlCommand("INSERT INTO tbusuarios (nome, email, senha) VALUES (@NOME, @EMAIL, @SENHA)", conexao);

                strComando.Parameters.Add(new MySqlParameter("@NOME", nome));
                strComando.Parameters.Add(new MySqlParameter("@EMAIL", email));
                strComando.Parameters.Add(new MySqlParameter("@SENHA", senha));

                var cmdExec = strComando.ExecuteNonQuery();

                if (cmdExec > 0)
                {
                    Console.WriteLine($"O comando foi executado com sucesso! {cmdExec} registo(s) afetado(s)");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            finally
            { 
                conexao.Close();
            }

        }

        static void aguardarSair()
        {
            Console.WriteLine("Pressione ESC para voltar ao menu... ");
            while (Console.ReadKey().Key != ConsoleKey.Escape) { }
            Console.Clear();
        }
    }   
}
