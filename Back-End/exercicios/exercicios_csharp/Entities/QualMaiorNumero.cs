using System;
using System.Collections.Generic;
using System.Linq;

namespace exercicios_csharp.Entities
{
    class QualMaiorNumero
    {
        public List<int> ListaNumeros { get; set; }

        public QualMaiorNumero(List<int> listaNumeros)
        {
            ListaNumeros = listaNumeros;
        }

        public QualMaiorNumero()
        {

        }

        public int AcharMaiorNumero()
        {
            return this.ListaNumeros.Max();
        }        
    }
}
