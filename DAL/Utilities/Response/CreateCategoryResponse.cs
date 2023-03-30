using DAL.Utilities.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Utilities.Response
{
    public class CreateCategoryResponse
    {
        public string? message { get; set; }
        public CategoryResponse? category { get; set; }
    }
}
