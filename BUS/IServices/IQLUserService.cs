
using DAL.Entities;
using DAL.Utilities.Request;
using DAL.Utilities.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    public interface IQLUserService
    {
        Task Register(RegisterRequest user);
        Task<LoginResponse> Login(LoginRequest login);
        Task<LogoutResponse> Logout(int userId);
        Task<RefreshTokenResponse> RefreshToken(string refreshToken);
    }
}
