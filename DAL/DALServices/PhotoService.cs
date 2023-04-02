using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using DAL.IDALServices;
using DAL.Utilities.Support;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DALServices
{
    public class PhotoService :IPhotoService
    {
        private readonly Cloudinary _cloudinary;
        public PhotoService(IOptions<CloudinarySettings> config ) 
        {
            var acc = new Account(
                config.Value.CloudName,
                config.Value.ApiKey,
                config.Value.ApiSecret
                );
            _cloudinary = new Cloudinary( acc );
        }
        public async Task<ImageUploadResult> AddPhotoAsync(IFormFile file)
        {
            var uploadResult = new ImageUploadResult();
            if(file.Length > 0 )
            {
                using var stream = file.OpenReadStream();
                var uploadParams = new ImageUploadParams
                {
                    File = new FileDescription(file.FileName, stream)
                };
                uploadResult = await _cloudinary.UploadAsync( uploadParams );
            }
            return uploadResult;
        }
        public async Task<DeletionResult> DeletePhotoAsync(string fileId)
        {
            var deleteParams = new DeletionParams(fileId);
            var result = await _cloudinary.DestroyAsync(deleteParams);
            return result;
        }
    }
}
