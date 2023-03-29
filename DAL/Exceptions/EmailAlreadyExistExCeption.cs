using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Exceptions
{
    public class EmailAlreadyExistExCeption : Exception
    {
        const string errorMessage = "Email already exists!";
        public EmailAlreadyExistExCeption() : base(errorMessage)
        {

        }
    }
}
