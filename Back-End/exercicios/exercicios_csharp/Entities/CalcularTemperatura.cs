using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios_csharp.Entities
{
    class CalcularTemperatura
    {
        public double TempCelcius { get; set; }

        public CalcularTemperatura(double tempCelcius)
        {
            this.TempCelcius = tempCelcius;
        }

        public CalcularTemperatura()
        {
            
        }


        public double CalcTemperatura()
        {
            double Fahrenheit = this.TempCelcius * 1.8 + 32;
            return Fahrenheit;
        }
    }
}
