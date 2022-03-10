using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using POO_ASPNET.Entities;


namespace POO_ASPNET.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutomovelController : Controller
    {

        [HttpGet]
        public List<Veiculo> Get()
        {
            List<Veiculo> listaVeiculos = Mock.GetVeiculo();
            return listaVeiculos;
        }

        //[HttpPost("acelerar/{id}")]
        //public List<Veiculo>Acelerar(int id)
        //{

        //}
    }
}

