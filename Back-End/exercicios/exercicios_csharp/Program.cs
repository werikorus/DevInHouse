using System;
using exercicios_csharp.Entities;
using System.Collections.Generic;

namespace exercicios_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe 10 números: ");
            List<int> numeros = new List<int>();
            for(var i=1; i<=10; i++)
            {
                numeros.Add(int.Parse(Console.ReadLine()));
            }
            Ordenacao Ordenacao = new Ordenacao(numeros);
            Console.WriteLine($"Números ordenados descrescente: ");
            Ordenacao.OrdenarNumeros();
        }
    }
}

