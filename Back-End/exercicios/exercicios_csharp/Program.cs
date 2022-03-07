using System;
using exercicios_csharp.Entities;
using System.Collections.Generic;
using System.Collections;

namespace exercicios_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe quantos funcionários quer reajustar o salário: ");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> Pessoas = new List<Funcionario>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Funcionário #0{i}");

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Cargo: ");
                string cargo = Console.ReadLine();

                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine());

                Funcionario funcionario = new(nome, cargo, salario);

                Pessoas.Add(funcionario);
            }

            GerenciadorSalario Gerenciador = new GerenciadorSalario(Pessoas);
            Gerenciador.GerenciarSalario();
        }
    }
}

