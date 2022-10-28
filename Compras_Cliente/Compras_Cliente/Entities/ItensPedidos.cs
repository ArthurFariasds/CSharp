using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compras_Cliente.Entities
{
    internal class ItensPedidos
    {
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public Produto Produto { get; set; }

        public ItensPedidos()
        {
        }
        public ItensPedidos(int quantidade, double preco, Produto produto)
        {
            Quantidade = quantidade;
            Preco = preco;
            Produto = produto;  
        }
        public double SubTotal()
        {
            return Quantidade * Preco;
        }
    }
}
