using BUS.IServices;
using BUS.Services;
using DAL.Entities;
using DAL.Utilities.Request;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly IQLProductService _qLProductService;

        public ProductController(IQLProductService qLProductService)
        {
            _qLProductService = qLProductService;
        }
        [HttpPost("Add")]
        [Authorize]
        public async Task<IActionResult> add([FromBody] CreateProductRequest product)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var response = await _qLProductService.add(product);
                return Ok(response);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
