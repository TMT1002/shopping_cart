using DAL.Utilities.Response;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    public interface IQLCloudinaryService
    {
        Task<UploadPhotoResponse> uploadPhoto(IFormFile file);
    }
}
