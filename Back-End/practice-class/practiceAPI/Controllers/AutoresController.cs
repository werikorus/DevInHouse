using Microsoft.AspNetCore.Http;
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
        
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
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

            //first or default se não tiver resultado ele traz default para não dar erro
            Autor result = autores.FirstOrDefault(x => x.Id == id);

            return result;
        }

        // POST api/<AutorController>
        [HttpPost]        
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public  IActionResult Post([FromBody] Autor autor)
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

            return StatusCode(201);
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
