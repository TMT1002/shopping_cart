using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IDALServices
{
    public interface IProductService
    {
        Task add(Product product);
        Task<Product?> getById(int productId);
        Task update(Product product);
    }
}
