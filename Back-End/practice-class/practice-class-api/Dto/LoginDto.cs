using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace practice_class_api.Dto
{
    public class LoginDto
    {
        public string Username { get; set; }
        public string Role { get; set; }
        public string Password { get; set; }
    }
}
