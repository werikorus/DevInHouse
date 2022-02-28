using System;
using exercicios_csharp.Entities;

namespace exercicios_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número inteiro positivo: ");
            int numero = int.Parse(Console.ReadLine());
            InverterNumeros invert = new InverterNumeros(numero);
            int numeroInvertido = invert.Inverter();
            Console.WriteLine($"O número invertido é: {numeroInvertido}");
        }
    }
}

