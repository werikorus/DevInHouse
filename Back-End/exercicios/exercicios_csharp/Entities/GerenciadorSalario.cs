using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios_csharp.Entities
{
    class GerenciadorSalario
    {
        public List<Funcionario> Funcionarios { get; set; }

        public GerenciadorSalario(List<Funcionario> funcionarios)
        {
            Funcionarios = funcionarios;
        }

        public GerenciadorSalario()
        {

        }

        public void GerenciarSalario()
        {
            double taxa = 0;
            double valorAumento = 0;
            double novoSalario = 0;

            foreach (Funcionario funcionario in Funcionarios)
            {
                
                if (funcionario.Salario <= 280)
                {
                    taxa = 0.2;                    
                }
                else

                if (funcionario.Salario >= 280 && funcionario.Salario <= 700)
                {
                    taxa = 0.15;
                }
                else

                if (funcionario.Salario >= 700 && funcionario.Salario <= 1500)
                {
                    taxa = 0.10;
                };

                if (funcionario.Salario >= 1500)
                {
                    taxa = 0.05;
                };

                novoSalario = funcionario.Salario + (funcionario.Salario * taxa);
                valorAumento = (funcionario.Salario - novoSalario);


                string msg = $"Funcionário: {funcionario.Name}\n" +
                             $"Salário antigo: R$ {funcionario.Salario}\n" +
                             $"Salário novo: R$ {novoSalario}\n" +
                             $"Valor do aumento: R$ {Math.Abs(valorAumento)}\n" +
                             $"Valor do reajuste de {taxa}%";
                
                
                Console.WriteLine(msg);
            }
        }
    }

}
