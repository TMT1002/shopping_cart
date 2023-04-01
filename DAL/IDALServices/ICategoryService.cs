using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IDALServices
{
    public interface ICategoryService
    {
        Task Add(Category category);
        Task Update(Category category);
        Task<Category?> GetById(int id);
        Task Delete(Category category);
    }
}
