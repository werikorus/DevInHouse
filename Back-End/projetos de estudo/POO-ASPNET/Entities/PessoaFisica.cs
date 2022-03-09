using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using POO_ASPNET.Entities;

namespace POO_ASPNET.Entities
{
    public class PessoaFisica : Pessoa
    {
        public string CPF { get; set; }

        public PessoaFisica(string nome) : base(nome + "Eu sou PF") { }

        public override void PagarImposto(string tipoImposto = "IRPF")
        {
            base.PagarImposto(tipoImposto);
        }
    }
}
