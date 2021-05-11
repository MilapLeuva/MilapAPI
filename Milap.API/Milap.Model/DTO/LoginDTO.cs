using System;
using System.Collections.Generic;
using System.Text;

namespace Milap.Model.DTO
{
    public class LoginDTO
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public int LoginType { get; set; }
    }
}
