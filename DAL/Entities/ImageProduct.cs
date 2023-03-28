using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class ImageProduct
    {
        [Key]
        public int Id { get; set; }
        public string? linkImg { get; set; }
        public string? imgName { get; set; }
        public Product? product { get; set; }
    }
}
