using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Exceptions
{
    public class RefreshTokenWrongException : Exception
    {
        const string errorMessage = "Refresh token wrong!";
        public RefreshTokenWrongException() : base(errorMessage)
        {

        }
    }
}
