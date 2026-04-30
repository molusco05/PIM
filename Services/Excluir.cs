using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PIM.Services;


namespace PIM.Services
{
    public static class Excluir
    {
        public static void ExcluirCliente()
        {
            Cadastro.ListarClientes();

            if (Cadastro.Clientes.Count == 0) return;

            Console.Write("\nDigite o número do cliente para excluir: ");
            if (!int.TryParse(Console.ReadLine(), out int index))
            {
                Console.WriteLine("❌ Entrada inválida!");
                return;
            }

            if (index > 0 && index <= Cadastro.Clientes.Count)
            {
                var cliente = Cadastro.Clientes[index - 1];

                Console.Write($"Tem certeza que deseja excluir {cliente.Nome}? (S/N): ");
                string confirm = Console.ReadLine().ToUpper();

                if (confirm == "S")
                {
                    Cadastro.Clientes.RemoveAt(index - 1);
                    Console.WriteLine("✅ Cliente excluído com sucesso!");
                }
                else
                {
                    Console.WriteLine("❌ Operação cancelada.");
                }
            }
            else
            {
                Console.WriteLine("❌ Cliente inválido.");
            }
        }

        public static void ExcluirProduto()
        {
            Cadastro.ListarProdutos();

            if (Cadastro.Produtos.Count == 0) return;

            Console.Write("\nDigite o número do produto para excluir: ");
            if (!int.TryParse(Console.ReadLine(), out int index))
            {
                Console.WriteLine("❌ Entrada inválida!");
                return;
            }

            if (index > 0 && index <= Cadastro.Produtos.Count)
            {
                var produto = Cadastro.Produtos[index - 1];

                Console.Write($"Tem certeza que deseja excluir {produto.Descricao}? (S/N): ");
                string confirm = Console.ReadLine().ToUpper();

                if (confirm == "S")
                {
                    Cadastro.Produtos.RemoveAt(index - 1);
                    Console.WriteLine("✅ Produto excluído com sucesso!");
                }
                else
                {
                    Console.WriteLine("❌ Operação cancelada.");
                }
            }
            else
            {
                Console.WriteLine("❌ Produto inválido.");
            }
        }
    }
}
