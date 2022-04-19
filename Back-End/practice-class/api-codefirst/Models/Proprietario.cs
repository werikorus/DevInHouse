using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_codefirst.Models
{
    public class Proprietario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Contato> Contatos { get; set; }
    }
}
