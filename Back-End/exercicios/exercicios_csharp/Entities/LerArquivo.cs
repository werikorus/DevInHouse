using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace exercicios_csharp.Entities
{
    class LerArquivo
    {
        public string Caminho { get; set; }

        public LerArquivo()
        {

        }

        public LerArquivo(string caminho)
        {
            Caminho = caminho;
        }

        public string VerificarAlunosNotaBaixa()
        {

            StreamReader file = new StreamReader("Alunos.json");
            string jsonString = file.ReadToEnd();

            Alunos alunos = JsonConvert.DeserializeObject<Alunos>(jsonString);


            if (alunos.Nota < 5)
            {
                return alunos.Nome;
            }
            else
                return "Nenhum aluno com nota baixa!";
        }

    }
}
