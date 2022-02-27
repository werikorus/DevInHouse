using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace exercicios_csharp.Entities
{
    class CalcularRaio
    {
        public double Raio { get; set; }

        public CalcularRaio(double raio)
        {
            this.Raio = raio;
        }
        public CalcularRaio()
        {
            
        }

        public double CalcularRaioCirculo()
        {
            double pi = 3.14159;
            double total = pi * (this.Raio * this.Raio);

            return total;
        }
        
    }
}
