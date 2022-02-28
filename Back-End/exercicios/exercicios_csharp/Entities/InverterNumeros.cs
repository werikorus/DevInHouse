using System;
using System.Linq;

namespace exercicios_csharp.Entities
{
    class InverterNumeros
    {
        public int Numeros { get; set; }

        public InverterNumeros(int numeros)
        {
            Numeros = numeros;
        }

        public InverterNumeros()
        {
        }

        public int Inverter()
        {
            char[] vetor = this.Numeros.ToString().ToCharArray();
            Array.Reverse(vetor);
            return Int32.Parse(new String(vetor));
        }
    }
}
