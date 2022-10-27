using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using SalarioFuncionario.Entities.Enums;

namespace SalarioFuncionario.Entities
{
    internal class Funcionario
    {
        public string Nome { get; set; }
        public WorkerLevel Nivel { get; set; }
        public double SalarioBase { get; set; }
        public Departamento Departamento { get; set; }
        public List<Contrato> Contratos { get; set; } = new List<Contrato>();

        public Funcionario()
        {
        }

        public Funcionario(string nome, WorkerLevel nivel, double salarioBase, Departamento departamento)
        {
            Nome = nome;
            Nivel = nivel;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }

        public void AddContrato(Contrato contrato)
        {
            Contratos.Add(contrato);
        }
        public void RemoveContrato(Contrato contrato)
        {
            Contratos.Remove(contrato);
        }
        public double Ganhos(int mes, int ano)
        {
            double soma = SalarioBase;
            foreach(Contrato contrato in Contratos)
            {
                if(contrato.Data.Year == ano && contrato.Data.Month == mes)
                {
                    soma += contrato.ValorTotal();
                }
            }
            return soma;
        }
    }
}
