using api_codefirst.Context;
using api_codefirst.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

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

        [HttpPost]
        public void PostImovel([FromBody] Imovel imovel)
        {
            _context.Imoveis.Add(imovel);
            _context.SaveChanges();
        }

        [HttpPut]
        public void PutImovel([FromBody] Imovel imovel)
        {
            _context.Imoveis.Update(imovel);
            _context.SaveChanges();
        }

        [HttpGet("{imovelId}")]
        public Imovel GetImoveis([FromRoute]int imovelId)
        {
            return _context.Imoveis.FirstOrDefault(x => x.Id == imovelId);
        }

        [HttpDelete("{imovelId}")]
        public void DeleteImovel([FromRoute]int imovelId)
        {
            var imovel = _context.Imoveis.FirstOrDefault(x => x.Id == imovelId);
            _context.Imoveis.Remove(imovel);
            _context.SaveChanges();
        }
    }
}
