using Compras_Cliente.Entities.Enum;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Text;


namespace Compras_Cliente.Entities
{
    internal class Pedido
    {
        public DateTime Momento { get; set; }
        public StatusPedido Status { get; set; }
        public Cliente Cliente { get; set; }
        public List<ItensPedidos> Itens { get; set; } = new List<ItensPedidos>();

        public Pedido()
        {
        }
        public Pedido(DateTime momento, StatusPedido status, Cliente cliente)
        {
            Momento = momento;
            Status = status;
            Cliente = cliente;
        }

        public void AddItem(ItensPedidos item)
        {
            Itens.Add(item);
        }
        public void RemoveItem(ItensPedidos item)
        {
            Itens.Remove(item);
        }

        public double Total()
        {
            double soma = 0;
            foreach (ItensPedidos itens in Itens)
            {
                soma += itens.SubTotal();
            }
            return soma;
        }

        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Momento do pedido: " + Momento.ToString());
            sb.AppendLine("Status do pedido: " + Status.ToString());
            foreach (ItensPedidos i in Itens)
            {
                sb.AppendLine("Produto: " + i.Produto.Nome + "| " + "Preço: " + i.Preco + "| " + "Quantidade: " +i.Quantidade +"| "+ "Subtotal: " + i.SubTotal());
            }
            sb.AppendLine("Total: " + Total());
            return sb.ToString();
        }


    }
}
