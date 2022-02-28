using System;
using exercicios_csharp.Entities;
using System.Collections.Generic;

namespace exercicios_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe 5 números: ");

            List<int> numeros = new List<int>();

            for(var i=0; i<=5; i++)
            {
                numeros.Add(int.Parse(Console.ReadLine()));
            }

            QualMaiorNumero MaiorNumero = new QualMaiorNumero(numeros);

            int MaxNumber = MaiorNumero.AcharMaiorNumero();

            Console.WriteLine($"O maior número é: {MaxNumber}");
        }
    }
}

