﻿using System;

namespace SalarioFuncionario.Entities
{
    internal class Departamento
    {
        public string Nome { get; set; }

        public Departamento()
        {
        }
        public Departamento(string nome)
        {
            Nome = nome;
        }
    }
}