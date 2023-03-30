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
    public class CategoryService : ICategoryService
    {
        private readonly ShoppingCartContext _context;
        public CategoryService(ShoppingCartContext context)
        {
            _context = context;
        }
        public async Task Add(Category category)
        {
            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();
        }
        public async Task Update(Category category)
        {
            _context.Categories.Update(category);
            await _context.SaveChangesAsync();
        }
        public async Task<Category?> GetById(int id)
        {
            var result = await _context.Categories.FirstOrDefaultAsync(c => c.Id == id);
            return result;
        }

    }
}
