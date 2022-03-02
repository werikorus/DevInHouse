using System;
using exercicios_csharp.Entities;
using System.Collections.Generic;

namespace exercicios_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe 3 lados de um triângulo!");
            Console.Write("Lado A: ");
            double A = double.Parse(Console.ReadLine());
            
            Console.Write("Lado B: ");
            double B = double.Parse(Console.ReadLine());

            Console.Write("Lado C: ");
            double C = double.Parse(Console.ReadLine());

            Triangulo triangulo = new(A, B, C);

            if (!triangulo.VerificarTriangulo())
            {
                Console.WriteLine("Não pode ser um triângulo!");
            }
            else
            {
                string tipoTriangulo = triangulo.TipoTriangulo();
                Console.WriteLine($"O tipo do triângulo é: {tipoTriangulo}");
            }

        }
    }
}

