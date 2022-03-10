using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_ASPNET.Entities
{
    public static class Mock
    {
        public static List<Veiculo> GetVeiculo()
        {

            List<Veiculo> veiculos = new List<Veiculo>();

            var v1 = new Carro("Fiesta");
            var v2 = new Carro("Honda-Civic");
            var v3 = new Carro("UNO");
            var v4 = new Carro("Gol");
            var v5 = new Carro("Brasilia");
            var v6 = new Moto("CG 150");
            var v7 = new Moto("CB 250");
            var v8 = new Moto("TODAY 100CC");
            var v9 = new Moto("BIZ 125");

            veiculos.Add(v1);
            veiculos.Add(v2);
            veiculos.Add(v3);
            veiculos.Add(v4);
            veiculos.Add(v5);
            veiculos.Add(v6); 
            veiculos.Add(v7);
            veiculos.Add(v8);
            veiculos.Add(v9);

            return veiculos;
        }
    }
}

