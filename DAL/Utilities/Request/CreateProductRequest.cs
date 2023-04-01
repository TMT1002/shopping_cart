using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace DAL.Utilities.Request
{
    public class CreateProductRequest
    {
        [Required]
        public string? nameProduct { get; set; }
        [Required]
        public string? description { get; set; }
        [Required]
        public float price { get; set; }
        [DefaultValue(0)]
        public float discountPrecent { get; set; }
        [Required]
        public string? brand { get; set; }
        [Required]
        public uint stockQuantity { get; set; }
        public string? thumbnailImage { get; set; }
        public string? thumbnailImgName { get; set; }
        [Required]
        public int categoryId { get; set; }
    }
}
