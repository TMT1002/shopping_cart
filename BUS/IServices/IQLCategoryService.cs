using DAL.Entities;
using DAL.Utilities.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    public interface IQLCategoryService
    {
        Task<CreateCategoryResponse> AddCategory(Category category);
        Task<UpdateCategoryResponse> UpdateCategory(Category category);
    }
}
