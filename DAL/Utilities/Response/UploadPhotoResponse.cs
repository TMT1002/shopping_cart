using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Utilities.Response
{
    public class UploadPhotoResponse
    {
        public string message { get; set; }
        public string photoName { get; set; }
        public string photoUrl { get; set; }
    }
}
