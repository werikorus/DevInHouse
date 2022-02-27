using System;
using exercicios_csharp.Entities;

namespace exercicios_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o raio: ");
            double raio = float.Parse(Console.ReadLine());

            CalcularRaio calcular = new CalcularRaio(raio);

            double total = calcular.CalcularRaioCirculo();


            Console.WriteLine($"O total da área é : {total}");

        }
    }
}

