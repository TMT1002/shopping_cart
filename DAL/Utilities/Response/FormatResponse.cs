using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Utilities.Response
{
    public class FormatResponse
    {
        public HttpStatusCode StatusCode;
        public string? Message;
    }
}
