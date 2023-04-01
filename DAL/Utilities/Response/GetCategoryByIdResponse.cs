using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Utilities.Response
{
    public class GetCategoryByIdResponse
    {
        public string? message { get; set; }
        public Category? category { get; set; }
    }
}
