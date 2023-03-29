using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Exceptions
{
    public class PasswordIsWrongException : Exception
    {
        const string errorMessage = "Password is wrong!";
        public PasswordIsWrongException() : base(errorMessage)
        {

        }
    }
}
