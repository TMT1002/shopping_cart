using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Utilities.Response
{
    public class LoginResponse
    {
        public User? user { get; set; }
        public string? message { get; set; }
        public string? token { get; set; }
    }
}
