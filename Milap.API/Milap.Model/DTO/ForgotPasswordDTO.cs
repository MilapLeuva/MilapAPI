using System;
using System.Collections.Generic;
using System.Text;

namespace Milap.Model.DTO
{
    public class ForgotPasswordDTO
    {
        public string  ForgotPasswordToken { get; set; }
        public string  Email { get; set; }
    }
}
