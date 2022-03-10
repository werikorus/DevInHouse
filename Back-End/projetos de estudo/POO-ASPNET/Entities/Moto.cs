using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_ASPNET.Entities
{
    public class Moto : Veiculo
    {
        public Moto(string nome) : base(nome) { }

        public override void Acelerar(int velocidade)
        {
            base.Acelerar(23453);
        }
    }
}
