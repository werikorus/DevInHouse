using System;
using System.Collections.Generic;
using System.Text;

namespace practice_project.Entities
{
    public class Client
    {
        public string Name { get; private set; }
        public string CPF { get; private set; }
        public string  RG { get; private set; }
        public string  Adress { get; private set; }

        public Client(string name, string cpf, string rg, string adress)
        {
            Name = name;
            CPF = cpf;
            RG = rg;
            Adress = adress;
        }
    }
}
