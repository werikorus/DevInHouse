using api_codefirst.Context;
using api_codefirst.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_codefirst.Controllers
{
    [Route("api/imovel")]
    [ApiController]
    public class ImoveisController : ControllerBase
    {
        private readonly Sqlcontext _context;
        public ImoveisController(Sqlcontext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Imovel> GetImoveis()
        {
            return _context.Imoveis.ToList();
        }
    }
}
