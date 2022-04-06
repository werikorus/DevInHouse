using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace practiceAPI.Models
{
    public class Autor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public bool Ativo { get; set; }
    }
}
