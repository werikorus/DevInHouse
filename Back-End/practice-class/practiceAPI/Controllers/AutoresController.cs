using Microsoft.AspNetCore.Mvc;
using practiceAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace practiceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutoresController : ControllerBase
    {
        // GET: api/<AutorController>
        [HttpGet]
        public IEnumerable<Autor> Get()
        {
            return new List<Autor>
            {
                new Autor
                {
                    Id = 1,
                    Ativo = true,
                    DataNascimento = new DateTime(1990, 09, 26),
                    Nome = "Werik Santos",
                },

                new Autor
                {
                    Id = 2,
                    Ativo = true,
                    DataNascimento = new DateTime(2000, 05, 24),
                    Nome = "Ester Carvalho",
                }
            };
        }

        // GET api/<AutorController>/5
        [HttpGet("{id}")]
        public Autor Get(int id)
        {
            var autores = new List<Autor>
            {
                new Autor
                {
                    Id = 1,
                    Ativo = true,
                    DataNascimento = new DateTime(1990, 09, 26),
                    Nome = "Werik Santos",
                },

                new Autor
                {
                    Id = 2,
                    Ativo = true,
                    DataNascimento = new DateTime(2000, 05, 24),
                    Nome = "Ester Carvalho",
                }
            };

            //first or default se não tiver resultado eele traz default para não dar erro
            Autor result = autores.FirstOrDefault(x => x.Id == id);

            return result;
        }

        // POST api/<AutorController>
        [HttpPost]
        public List<Autor> Post([FromBody] Autor autor)
        {
            var autores = new List<Autor>
            {
                new Autor
                {
                    Id = 1,
                    Ativo = true,
                    DataNascimento = new DateTime(1990, 09, 26),
                    Nome = "Werik Santos",
                },

                new Autor
                {
                    Id = 2,
                    Ativo = true,
                    DataNascimento = new DateTime(2000, 05, 24),
                    Nome = "Ester Carvalho",
                }
            };

            autores.Add(autor);

            return autores;
        }

        // PUT api/<AutorController>/5
        [HttpPut("{id}")]
        public Autor Put(int id, [FromBody] Autor autor)
        {
            var autores = new List<Autor>
            {
                new Autor
                {
                    Id = 1,
                    Ativo = true,
                    DataNascimento = new DateTime(1990, 09, 26),
                    Nome = "Werik Santos",
                },

                new Autor
                {
                    Id = 2,
                    Ativo = true,
                    DataNascimento = new DateTime(2000, 05, 24),
                    Nome = "Ester Carvalho",
                }
            };

            var autorAlterado = autores.Where(x => x.Id == autor.Id)
                .Select(x => new Autor
                {
                    Id = x.Id,
                    Ativo = autor.Ativo,
                    DataNascimento = autor.DataNascimento,
                    Nome = autor.Nome
                }).FirstOrDefault();

            return autorAlterado;
        }

        // DELETE api/<AutorController>/5
        [HttpDelete("{id}")]
        public List<Autor> Delete(int id)
        {
            var autores = new List<Autor>
            {
                new Autor
                {
                    Id = 1,
                    Ativo = true,
                    DataNascimento = new DateTime(1990, 09, 26),
                    Nome = "Werik Santos",
                },

                new Autor
                {
                    Id = 2,
                    Ativo = true,
                    DataNascimento = new DateTime(2000, 05, 24),
                    Nome = "Ester Carvalho",
                }
            };

            //first or default se não tiver resultado eele traz default para não dar erro
            Autor autor = autores.FirstOrDefault(x => x.Id == id);
            autores.Remove(autor);
            return autores;
        }
    }
}
