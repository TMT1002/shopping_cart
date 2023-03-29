using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Exceptions
{
    public class AccountNotFoundException : Exception
    {
        const string errorMessage = "Not Found Account";
        public AccountNotFoundException() : base(errorMessage)
        {

        }
    }
}
