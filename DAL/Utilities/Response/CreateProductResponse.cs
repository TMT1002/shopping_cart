using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Utilities.Response
{
    public class CreateProductResponse
    {
        public string message { get; set; }
        public Product product { get; set; }
    }
}
