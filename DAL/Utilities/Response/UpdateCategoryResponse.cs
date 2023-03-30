using DAL.Utilities.Support;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Utilities.Response
{
    public class UpdateCategoryResponse
    {
        public string? name { get; set; }
        public CategoryResponse? categoryResponse { get; set; }
    }
}
