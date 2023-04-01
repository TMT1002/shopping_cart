using BUS.IServices;
using DAL.DALServices;
using DAL.Entities;
using DAL.Exceptions;
using DAL.IDALServices;
using DAL.Utilities.Request;
using DAL.Utilities.Response;
using DAL.Utilities.Support;
using Google.Api;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
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
        private readonly ITokenService _tokenService;
        IConfiguration _configuration;
        public QLUserService(IUserService userService, IConfiguration configuration, ITokenService tokenService)
        {
            _userService = userService;
            _configuration = configuration;
            _tokenService = tokenService;
        }
        public async Task Register(RegisterRequest newUser)
        {
            //var account = _userService.FindAccountByEmail(newUser.email);
            //if(account != null) { throw new EmailAlreadyExistExCeption(); }
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

        public async Task<LoginResponse> Login(LoginRequest login)
        {
            var account = await _userService.FindAccountByEmail(login.email);
            if (account == null) { throw new AccountNotFoundException(); }
            if(!BCrypt.Net.BCrypt.Verify(login.password, account.password)) 
            {
                throw new PasswordIsWrongException();
            }
            var signingCredential = new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"])), SecurityAlgorithms.HmacSha256);
            var signingTokenCredential = new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:RefreshTokenKey"])), SecurityAlgorithms.HmacSha256);
            var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Email, account.email),
                    new Claim("Id", account.id.ToString()),
                    new Claim(ClaimTypes.Role, account.role.ToString()),
                };
            var access = new JwtSecurityToken(
                issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Audience"],
                expires:DateTime.Now.AddMinutes(100),
                signingCredentials: signingCredential,
                claims: claims
                );
            var refresh = new JwtSecurityToken(
                expires: DateTime.Now.AddDays(10),
                signingCredentials: signingTokenCredential,
                claims: claims
                );
            string accessToken = new JwtSecurityTokenHandler().WriteToken(access);
            string refreshToken = new JwtSecurityTokenHandler().WriteToken(refresh);
            var token = new Token
            {
                accessToken = accessToken,
                refreshToken = refreshToken,
                user = account
            };
            await _tokenService.saveToken(token);
            var user = new UserLoginResponse
            {
                id = account.id,
                userName = account.userName,
                email = account.email,
                phoneNumber = account.phoneNumber,
                isActive = account.isActive,
                avatarLink = account.avatarLink,
                avatarName = account.avatarName,
                verifyContact = account.verifyContact,
                verifyEmail = account.verifyEmail,
                role = account.role
            };
            LoginResponse response = new()
            {
                user = user,
                message = "Login successfully!",
                accessToken = accessToken,
                refreshToken = refreshToken

            };
            return response;
        }
        public async Task<LogoutResponse> Logout(int userId)
        {
            var account = await _userService.FindAccountById(userId);
            if (account == null) { throw new AccountNotFoundException(); }
            await _tokenService.deleteToken(userId);
            var response = new LogoutResponse
            {
                message = "Log out successfully!"
            };
            return response;
        }
        public async Task<RefreshTokenResponse> RefreshToken(string token)
        {
            var refreshToken = await _tokenService.findByRefreshToken(token);
            if(token != refreshToken||refreshToken == null)
            {
                throw new RefreshTokenWrongException();
            }
            // tạo mới access và refresh token
            var response = new RefreshTokenResponse
            {
                accessToken = "dwd",
                refreshToken = "cdsc",
                message = "Get token success!"
            };
            return response;
        }
    }
}
