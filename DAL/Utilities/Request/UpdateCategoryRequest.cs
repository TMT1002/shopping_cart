using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Utilities.Request
{
    public class UpdateCategoryRequest
    {
        [Required]
        public int categoryId {  get; set; }
        [Required]
        public string? categoryName { get; set; }
    }
}
