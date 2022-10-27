using System;
using System.Globalization;
using SalarioFuncionario.Entities;
using SalarioFuncionario.Entities.Enums;


namespace SalarioFuncionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome do departamento: ");
            string nomeDepart = Console.ReadLine();
            Console.WriteLine("DADOS DO FUNCIONÁRIO");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Nivel (Junior/Pleno/Senior): ");
            string level = Console.ReadLine();
            WorkerLevel nivel = (WorkerLevel)Enum.Parse(typeof(WorkerLevel), level, true);
            Console.Write("Salário Base: ");
            double salarioBase = double.Parse(Console.ReadLine());

            Departamento dept = new Departamento(nomeDepart);
            Funcionario funcionario = new Funcionario(nome, nivel, salarioBase, dept);

            Console.Write("Quantos contratos para esse funcionário?: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Entre com o #{i}º dado do contrato: ");
                Console.Write("Data(dd/mm/aaaa): ");
                DateTime data = DateTime.Parse(Console.ReadLine());
                Console.Write("Valor por horas: ");
                double valorPorHora = double.Parse(Console.ReadLine());
                Console.Write("Duração(horas): ");
                int duracao = int.Parse(Console.ReadLine());

                Contrato contrato = new Contrato(data, valorPorHora, duracao);
                funcionario.AddContrato(contrato);
            }

            Console.WriteLine();
            Console.Write("Digite o mês e ano (mm/aaaa): ");
            string mesAno = Console.ReadLine();
            int mes = int.Parse(mesAno.Substring(0,2));
            int ano = int.Parse(mesAno.Substring(3));

            Console.WriteLine($"Nome: {funcionario.Nome}");
            Console.WriteLine($"Departamento: {funcionario.Departamento.Nome}");
            Console.WriteLine($"Nivel: {nivel}");
            Console.WriteLine($"Ganhos de {mesAno}: {funcionario.Ganhos(mes, ano)}");

            Console.ReadKey();
            
        }
    }
}
