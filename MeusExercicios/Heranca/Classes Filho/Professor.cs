﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    public class Professor : Funcionario
    {
        public string Curso { get; set; }

        public override string ObterNomeCompleto()
        {
            return $"" +
                $"{NumeroFuncionario} - {base.ObterNomeCompleto()}";
        }
        public Professor(string numeroFuncionario) : base (numeroFuncionario)
        {
            System.Console.WriteLine("Construiu o professor!");
        }
    }
}
