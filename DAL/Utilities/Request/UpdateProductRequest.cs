using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Utilities.Request
{
    public class UpdateProductRequest
    {
        public string? nameProduct { get; set; }
        public string? description { get; set; }
        public float? price { get; set; }
        public float? discountPrecent { get; set; }
        public string? brand { get; set; }
        public uint? stockQuantity { get; set; }
        public string? thumbnailImage { get; set; }
        public string? thumbnailImgName { get; set; }
        public int? categoryId { get; set; }
    }
}
