using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Exceptions
{
    public class ProductNotFoundException : Exception
    {
        const string errorMessage = "Not Found Product";
        public ProductNotFoundException() : base(errorMessage)
        {
        }
    }
}
