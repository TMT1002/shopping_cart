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
    public class ProductService : IProductService
    {
        readonly ShoppingCartContext _context;
        public ProductService(ShoppingCartContext context)
        {
            _context = context;
        }
        public async Task add(Product product)
        {
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
        }
        public async Task<Product?> getById(int productId)
        {
            var product = await _context.Products.FirstOrDefaultAsync(p => p.Id == productId);
            return product;
        }
    }
}
