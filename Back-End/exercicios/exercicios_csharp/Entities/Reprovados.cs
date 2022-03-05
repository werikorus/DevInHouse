using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;


namespace exercicios_csharp.Entities
{
    class Reprovados
    {
        public string Caminho { get; set; }

        public Reprovados()
        {

        }

        public Reprovados(string caminho)
        {
            Caminho = caminho;
        }

        public void VerificaESalvaAlunosNotaBaixa()
        {

            StreamReader file = new StreamReader("notas.json"); 
            string jsonString = file.ReadToEnd();

            Alunos alunos = JsonConvert.DeserializeObject<Alunos>(jsonString);
            

            if (alunos.Nota < 5)
            {
                string json = JsonConvert.SerializeObject(alunos);
                File.WriteAllText("reprovados.json", json);
            }
            
        }
    }
}
