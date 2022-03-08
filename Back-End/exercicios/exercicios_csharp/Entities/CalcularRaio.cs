using System;

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
            double total = pi*(this.Raio * this.Raio);
            return total;
        }
    }
}
