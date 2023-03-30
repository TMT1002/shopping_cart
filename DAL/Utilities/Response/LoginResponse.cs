using DAL.Entities;
using DAL.Utilities.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Utilities.Response
{
    public class LoginResponse
    {
        public UserLoginResponse? user { get; set; }
        public string? message { get; set; }
        public string? accessToken { get; set; }
        public string? refreshToken { get; set; }
    }
}
