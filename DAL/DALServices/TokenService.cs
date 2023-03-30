using DAL.Entities;
using DAL.IDALServices;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DALServices
{
    public class TokenService : ITokenService
    {
        private readonly ShoppingCartContext _context;
        public TokenService(ShoppingCartContext context)
        {
            _context = context;
        }
        public async Task saveToken(Token token)
        {
            await _context.Tokens.AddAsync(token);
            await _context.SaveChangesAsync();
        }
        public async Task deleteToken(int userId)
        {
            var tokens = await _context.Tokens.Where(t => t.userId == userId).ToListAsync();
            _context.Tokens.RemoveRange(tokens);
            await _context.SaveChangesAsync();
        }
        public async Task<string> findByRefreshToken(string token)
        {
            var tokens = await _context.Tokens.FirstOrDefaultAsync(t => t.refreshToken == token);
            return tokens.refreshToken;
        }
    }
}
