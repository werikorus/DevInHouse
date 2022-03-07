using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios_csharp.Entities
{
    class Funcionario
    {
        public String Name { get; set; }
        public string Cargo { get; set; }
        public double Salario { get; set; }

        public Funcionario(string name, string cargo, double salario)
        {
            Name = name;
            Cargo = cargo;
            Salario = salario;
        }
    }

}
