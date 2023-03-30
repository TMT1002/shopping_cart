using BUS.IServices;
using DAL.Entities;
using DAL.Exceptions;
using DAL.IDALServices;
using DAL.Utilities.Response;
using DAL.Utilities.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class QLCategoryService : IQLCategoryService
    {
        private readonly ICategoryService _categoryService;
        public QLCategoryService(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public async Task<CreateCategoryResponse> AddCategory(Category category)
        {
            await _categoryService.Add(category);
            CategoryResponse categoryCreate = new()
            {
                name = category.nameCategory
            };
            var response = new CreateCategoryResponse {
                message = "Create category success!",
                category = categoryCreate
            };
            return response;
        }
        public async Task<UpdateCategoryResponse> UpdateCategory(Category category)
        {
            var existingCategory = await _categoryService.GetById(category.Id);
            if (existingCategory != null) 
            {
                existingCategory.nameCategory = category.nameCategory;
                await _categoryService.Update(existingCategory);
                CategoryResponse categoryUpdate = new()
                {
                    name = category.nameCategory
                };
                var response = new UpdateCategoryResponse
                {
                    name = "Update category success!",
                    categoryResponse = categoryUpdate
                };
                return response;
                
            }
            throw new CategoryNotFoundException();
        }
    }
}
