using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using POO_ASPNET.Entities;


namespace POO_ASPNET.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        [HttpGet]
        public List<Pessoa> Get()
        {
            var listaPessoa = new List<Pessoa>();

            var p1 = new Pessoa("Werik");
            var p2 = new Pessoa("Ester");

            listaPessoa.Add(p1);
            listaPessoa.Add(p2);


            return listaPessoa;
        }

    }
}
