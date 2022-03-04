using System;
using exercicios_csharp.Entities;
using System.Collections.Generic;

namespace exercicios_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o caminho do arquivo JSON: ");
            string caminho = Console.ReadLine();

            LerArquivo ReadAndProcessFile = new(caminho);

            string alunoNotaBaixa = ReadAndProcessFile.VerificarAlunosNotaBaixa();

            Console.WriteLine("Alunos que tiraram nota baixa: ");
            Console.WriteLine(alunoNotaBaixa);

        }
    }
}

