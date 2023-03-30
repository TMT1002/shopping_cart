using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Utilities.Response
{
    public class RefreshTokenResponse
    {
        public string? accessToken {  get; set; }
        public string? refreshToken { get; set; }
        public string? message { get; set; }
    }
}
