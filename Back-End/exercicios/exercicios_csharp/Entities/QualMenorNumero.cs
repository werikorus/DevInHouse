using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios_csharp.Entities
{
    class QualMenorNumero
    {
        public List<int> ListaNumeros { get; set; }

        public QualMenorNumero(List<int> listaNumeros)
        {
            ListaNumeros = listaNumeros;
        }

        public QualMenorNumero()
        {

        }

        public int AcharMenorNumero()
        {
            return this.ListaNumeros.Min();
        }
    }
}
