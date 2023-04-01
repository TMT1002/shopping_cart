using BUS.IServices;
using DAL.Entities;
using DAL.Utilities.Request;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CategoryController : Controller
    {
        private readonly IQLCategoryService _qLCategoryService;

        public CategoryController(IQLCategoryService qLCategoryService)
        {
            _qLCategoryService = qLCategoryService;
        }

        [HttpPost("Add")]
        [Authorize]
        public async Task<IActionResult> add([FromBody] CreateCategoryRequest newCategory)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var category = new Category
                {
                    nameCategory = newCategory.name
                };
                var response = await _qLCategoryService.AddCategory(category);
                return Ok(response);

            } catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost("Update")]
        [Authorize]
        public async Task<IActionResult> Update([FromBody] UpdateCategoryRequest updateCategory)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var category = new Category
                {
                    Id = updateCategory.categoryId,
                    nameCategory = updateCategory.categoryName
                };
                var response = await _qLCategoryService.UpdateCategory(category);
                return Ok(response);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete("Delete/{id}")]
        [Authorize]
        public async Task<IActionResult> Update(int id)
        {
            try
            {
                var response = await _qLCategoryService.DeleteCategory(id);
                return Ok(response);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategoryById(int id)
        {
            try
            {
                var response = await _qLCategoryService.GetCategoryById(id);
                return Ok(response);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
