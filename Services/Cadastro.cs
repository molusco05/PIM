using PIM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM.Services
{
    public static class Cadastro
    {
        public static List<Cliente> Clientes { get; set; } = new List<Cliente>();
        public static List<Produto> Produtos { get; set; } = new List<Produto>();

        public static void CadastrarCliente()
        {
            var cliente = new Cliente();
            Console.Write("Nome: "); cliente.Nome = Console.ReadLine();
            Console.Write("Email: "); cliente.Email = Console.ReadLine();
            Console.Write("Senha: "); cliente.Senha = Console.ReadLine();
            Console.Write("Idade: "); int.TryParse(Console.ReadLine(), out int idade); cliente.Idade = idade;

            Clientes.Add(cliente);
            Console.WriteLine("\n✅ Cliente cadastrado!");
        }

        public static void CadastrarProduto()
        {
            var produto = new Produto();
            Console.Write("Categoria: "); produto.Categoria = Console.ReadLine();
            Console.Write("Valor: "); double.TryParse(Console.ReadLine(), out double valor); produto.Valor = valor;
            Console.Write("Descrição: "); produto.Descricao = Console.ReadLine();

            Produtos.Add(produto);
            Console.WriteLine("\n✅ Produto cadastrado!");
        }

        public static void ListarClientes()
        {
            Console.WriteLine("\n👥 CLIENTES CADASTRADOS");
            if (Clientes.Count == 0) { Console.WriteLine("Nenhum cliente."); return; }

            for (int i = 0; i < Clientes.Count; i++)
            {
                var c = Clientes[i];
                Console.WriteLine($"{i + 1}. {c.Nome} | {c.Email} | {c.Idade} anos");
            }
        }

        public static void ListarProdutos()
        {
            Console.WriteLine("\n💄 PRODUTOS CADASTRADOS");
            if (Produtos.Count == 0) { Console.WriteLine("Nenhum produto."); return; }

            for (int i = 0; i < Produtos.Count; i++)
            {
                var p = Produtos[i];
                Console.WriteLine($"{i + 1}. {p.Categoria} | R$ {p.Valor:F2} | {p.Descricao}");
            }
        }
    }
}
