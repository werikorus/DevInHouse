using System;
using System.Collections.Generic;

namespace exercicios_csharp.Entities
{
    class Ordenacao
    {
        public List<int> Numeros { get; set; }

        public Ordenacao(List<int> numeros)
        {
            this.Numeros = numeros;
        }

        public Ordenacao()
        {
        }

        public void OrdenarNumeros()
        {
            this.Numeros.Sort();
            this.Numeros.Reverse();

            foreach (int n in this.Numeros)
            {
                Console.WriteLine(n);
            }
        }
    }

}
