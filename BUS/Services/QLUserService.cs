using BUS.IServices;
using DAL.Entities;
using DAL.Exceptions;
using DAL.IDALServices;
using DAL.Utilities.Request;
using DAL.Utilities.Response;
using Google.Api;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
namespace BUS.Services
{
    public class QLUserService: IQLUserService
    {
        private readonly IUserService _userService;
        IConfiguration _configuration;
        public QLUserService(IUserService userService, IConfiguration configuration)
        {
            _userService = userService;
            _configuration = configuration;
        }
        public async Task Register(RegisterRequest newUser)
        {
            var account = _userService.FindAccountByEmail(newUser.email);
            if(account != null) { throw new EmailAlreadyExistExCeption(); }
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(newUser.password);
            User user = new()
            {
                userName = newUser.userName,
                password = passwordHash,
                email = newUser.email,
                phoneNumber = newUser.phoneNumber,
            };
            await _userService.CreateUser(user);
        }

        public Task<LoginResponse> Login(LoginRequest login)
        {
            var account = _userService.FindAccountByEmail(login.email);
            if (account.Result == null) { throw new AccountNotFoundException(); }
            if(!BCrypt.Net.BCrypt.Verify(login.password, account.Result.password)) 
            {
                throw new PasswordIsWrongException();
            }
            var signingCredential = new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"])), SecurityAlgorithms.HmacSha256);
            var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Email, account.Result.email),
                    new Claim("Id", account.Result.id.ToString()),
                    new Claim(ClaimTypes.Role, account.Result.role.ToString()),
                };
            var token = new JwtSecurityToken(
                issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Audience"],
                expires:DateTime.Now.AddMinutes(10),
                signingCredentials: signingCredential,
                claims: claims
                );
            string accessToken = new JwtSecurityTokenHandler().WriteToken(token);
            LoginResponse response = new()
            {
                user = account.Result,
                message = "Login successfully!",
                token = accessToken
            };
            return Task.FromResult(response);
        }
    }
}
