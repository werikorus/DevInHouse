using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_codefirst.Models
{
    public class Imovel
    {

        public int Id { get; set; }
        public string Titulo { get; set; }
        public string DescricaoCurta { get; set; }
        public string DescricaoLonga { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public float Preco { get; set; }
        public float Area { get; set; }
        public float ValorCondominio { get; set; }
        public Endereco Endereco { get; set; }

        public ICollection<Proprietario> Proprietarios { get; set; }

        //public EnumTipo TipoImovel { get; set; }
        //public decimal Endereco { get; set; }
    }
}
