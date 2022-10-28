using System;
using System.Data;
using Compras_Cliente.Entities;
using Compras_Cliente.Entities.Enum;

namespace Compras_Cliente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Data de nascimento: ");
            DateTime data = DateTime.Parse(Console.ReadLine());

            Cliente cliente = new Cliente(nome, email, data);

            Console.Clear();

            Console.WriteLine("=================DADOS DA COMPRA=================");

            Console.Write("Status(PagamentoPendente/Processando/Enviado/Entregue): ");
            string status = Console.ReadLine();
            StatusPedido sta = (StatusPedido)Enum.Parse(typeof(StatusPedido), status, true);
            Console.Write("Quantos pedidos para essa compra?: ");
            int n = int.Parse(Console.ReadLine());

            Pedido pedido = new Pedido(DateTime.Now, sta, cliente);

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Entre com os dados do #{i}º item:");
                Console.Write("Nome do produto: ");
                string name = Console.ReadLine();
                Console.Write("Preço do produto: ");
                double preco = double.Parse(Console.ReadLine());
                Console.Write("Quantidade do produto: ");
                int qntd = int.Parse(Console.ReadLine());

                Produto produto = new Produto(name, preco);
                ItensPedidos itens = new ItensPedidos(qntd, preco, produto);
                pedido.AddItem(itens);
                Console.Clear();
            }

            Console.Clear();

            Console.WriteLine("=================LISTA DE PEDIDOS=================");

            Console.WriteLine(cliente);
            Console.WriteLine(pedido);

            Console.ReadLine();
        }
    }
}
