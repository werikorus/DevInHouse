using System;
using exercicios_csharp.Entities;
using System.Collections.Generic;

namespace exercicios_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe 7 números: ");

            List<int> numeros = new List<int>();

            for(var i=0; i<=5; i++)
            {
                numeros.Add(int.Parse(Console.ReadLine()));
            }

            QualMenorNumero MenorNumero = new QualMenorNumero(numeros);

            int MinNumber = MenorNumero.AcharMenorNumero();

            Console.WriteLine($"O menor número é: {MinNumber}");
        }
    }
}

