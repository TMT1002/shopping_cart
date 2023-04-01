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
        [HttpGet("{productId}")]
        public async Task<IActionResult> getById(int productId)
        {
            try
            {
                var response = await _qLProductService.getById(productId);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut("Update/{productId}")]
        [Authorize]
        public async Task<IActionResult> updateById(int productId, [FromBody] UpdateProductRequest updateProduct)
        {
            try
            {
                if(updateProduct == null)
                {
                    throw new BadHttpRequestException("Can not update product");
                } else
                {
                    var response = await _qLProductService.updateById(productId, updateProduct);
                    return Ok(response);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete("Delete/{productId}")]
        [Authorize]
        public async Task<IActionResult> deleteProduct(int productId)
        {
            try
            {
                var response = await _qLProductService.deleteById(productId);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
