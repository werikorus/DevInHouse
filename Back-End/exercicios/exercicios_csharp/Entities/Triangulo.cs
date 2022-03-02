using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios_csharp.Entities
{
    class Triangulo
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Triangulo()
        {

        }

        public Triangulo(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }


        public Boolean VerificarTriangulo()
        {
            if ((A + B) < C)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public string TipoTriangulo()
        {
            string tipoTriangulo;

            if (A == B && A == C && B == C)
            {
                tipoTriangulo = "Equilátero";
            }
            else if (A == B || A == C || B == C)
            {
                tipoTriangulo = "Isósceles";
            }
            else
                tipoTriangulo = "Escaleno";

            return tipoTriangulo;
        }

    }
}
