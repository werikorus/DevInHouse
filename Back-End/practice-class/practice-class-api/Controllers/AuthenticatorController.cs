using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using practice_class_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using practice_class_api.Repository;
using practice_class_api.Dto;
using practice_class_api.Services;

namespace practice_class_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticatorController : ControllerBase
    {
        [HttpPost]
        [Route("login")]
        public IActionResult Login([FromBody] LoginDto dto) 
        {
            var user = UserRepository.VerifyUserAndPassword(dto.Username, dto.Password);
            if (user==null) 
                return NotFound();

            var token = TokenService.GenerateToken(dto);

            return Ok(token);
        }

    }
}
