using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5HT1.Dtos.Request
{
    public class AuthorizRequest
    {
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
