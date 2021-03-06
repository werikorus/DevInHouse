using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_ASPNET.Entities
{
    public class Veiculo
    {
        public int Id { get; set; }
        public string Nome { get; private set; }
        public string Modelo { get; set; }
        public int  Ano { get; set; }
        public int VelocidadeAtual { get; private set; }

        public Veiculo(string nome)
        {
            Nome = nome;
        }

        public virtual void Acelerar(int velocidade)
        {
            VelocidadeAtual += velocidade;
        }

    }
}
