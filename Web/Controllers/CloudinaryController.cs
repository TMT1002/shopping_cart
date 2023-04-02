using BUS.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CloudinaryController : Controller
    {
        private readonly IQLCloudinaryService _cloudinaryService;
        public CloudinaryController(IQLCloudinaryService cloudinaryService)
        {
            _cloudinaryService = cloudinaryService;
        }
        [HttpPost("Upload-photo")]
        [Authorize]
        public async Task<IActionResult> uploadPhoto(IFormFile file)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var response = await _cloudinaryService.uploadPhoto(file);
                return Ok(response);
            } catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }   
        }
    }
}
