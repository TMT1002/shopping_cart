using BUS.IServices;
using DAL.IDALServices;
using DAL.Utilities.Response;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class QLCloudinaryService : IQLCloudinaryService
    {
        private readonly IPhotoService _photoService;
        public QLCloudinaryService(IPhotoService photoService)
        {
            _photoService = photoService;
        }
        public async Task<UploadPhotoResponse> uploadPhoto(IFormFile file)
        {
            var result = await _photoService.AddPhotoAsync(file);
            var response = new UploadPhotoResponse
            {
                message = "Upload photo success!",
                photoName = file.Name,
                photoUrl = result.SecureUrl.ToString()
            };
            return response;
        }
    }
}
