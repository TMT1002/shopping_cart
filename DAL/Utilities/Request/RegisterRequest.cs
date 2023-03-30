using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Utilities.Request
{
    public class RegisterRequest
    {
        public string? userName { get; set; }
        public string? password { get; set; }
        public string? email { get; set; }
        public string? phoneNumber { get; set; }
    }
}
