using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using PIM.Services;

namespace PIM
{
   class Program
    {

        static void Main(string[] args)
        {
            int opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("\n🎨 SISTEMA DE MAQUIAGEM");
                Console.WriteLine("1 - Cadastrar Cliente");
                Console.WriteLine("2 - Cadastrar Produto");
                Console.WriteLine("3 - Listar Clientes");
                Console.WriteLine("4 - Listar Produtos");
                Console.WriteLine("5 - Excluir Cliente");
                Console.WriteLine("6 - Excluir Produto");
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha uma opção: ");


                int.TryParse(Console.ReadLine(), out opcao);

                switch (opcao)
                {
                    case 1:
                        Cadastro.CadastrarCliente();
                        break;

                    case 2:
                        Cadastro.CadastrarProduto();
                        break;

                    case 3:
                        Cadastro.ListarClientes();
                        break;

                    case 4:
                        Cadastro.ListarProdutos();
                        break;

                    case 5:
                        Excluir.ExcluirCliente();
                        break;

                    case 6:
                        Excluir.ExcluirProduto();
                        break;

                    case 0:
                        Console.WriteLine("👋 Encerrando o sistema...");
                        break;

                    default:
                        Console.WriteLine("❌ Opção inválida!");
                        break;
                }


                if (opcao != 0)
                {
                    Console.WriteLine("\n⏳ Pressione qualquer tecla...");
                    Console.ReadKey();
                }
            } while (opcao != 0);
        

    }
    }
}
