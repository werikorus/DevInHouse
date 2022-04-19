﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_codefirst.Models
{
    public class Endereco
    {
        public int Id { get; set; }
        public string Rua { get; set; }
        public string  Bairro { get; set; }
        public string Numero { get; set; }
        public string  Complemento { get; set; }
        public int Cep { get; set; }
        public string Cidade  { get; set; }
        public string Uf { get; set; }
    }
}
