using DAL.Entities;
using DAL.Exceptions;
using DAL.IDALServices;
using DAL.Utilities.Request;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DALServices
{
    public class UserService: IUserService
    {
        private readonly ShoppingCartContext _context;
        public UserService(ShoppingCartContext context)
        {
            _context = context;
        }
        public async Task CreateUser(User newUser)
        {
            _context.Users.Add(newUser);
            await _context.SaveChangesAsync();
        }
        public async Task<User?> FindAccountByEmail(string email)
        {
            var account = await _context.Users.FirstOrDefaultAsync(a => a.email == email);
            return account;
        }

        public async Task<User?> FindAccountById(int id)
        {
            var account = await _context.Users.FirstOrDefaultAsync(a => a.id == id);
            return account;
        }
    }
}
