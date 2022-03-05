using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios_csharp.Entities
{
    class Alunos
    {
        public string Nome { get; set; }
        public string Serie { get; set; }
        public double Nota { get; set; }


        public Alunos()
        {
            
        }

        public Alunos(string nome, string serie, double nota)
        {
            Nome = nome;
            Serie = serie;
            Nota = nota;
        }
    }
}
