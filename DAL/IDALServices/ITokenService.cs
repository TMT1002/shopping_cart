using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IDALServices
{
    public interface ITokenService
    {
        Task saveToken(Token token);
        Task deleteToken(int userId);   
    }
}
