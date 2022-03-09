using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using POO_ASPNET.Entities;

namespace POO_ASPNET.Entities
{

    public class PessoaJuridica : Pessoa
    {
        public string CNPJ { get; set; }

        public PessoaJuridica(string nome) : base(nome + "Eu sou PJ") { }

        public override void PagarImposto(string tipoImposto = "INNS")
        {
            base.PagarImposto(tipoImposto);
        }
    }

}
