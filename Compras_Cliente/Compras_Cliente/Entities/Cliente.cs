using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compras_Cliente.Entities
{
    internal class Cliente
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }

        public Cliente()
        {
        }

        public Cliente(string nome, string email, DateTime dataAniversario)
        {
            Nome = nome;
            Email = email;
            DataNascimento = dataAniversario;
        }

        public override string ToString()
        {
            return Nome + " (" + DataNascimento.ToString("dd/MM/yyyy") + ") - " + Email;
        }
    }
}
