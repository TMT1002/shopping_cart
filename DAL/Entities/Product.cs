using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Product
    {
        [Key] public int Id { get; set; }
        [Required]
        public string? nameProduct { get; set; }
        public string? description { get; set; }
        public float price { get; set; }
        public float discountPrecent { get; set; }
        public string? brand { get; set; }
        public uint stockQuantity { get; set; }
        public float rateAvgReview { get; set; }
        public string? thumbnailImage { get; set; }
        public string? thumbnailImgName { get; set; }
        public ICollection<Review>? reviews { get; set; }
        [Required]
        public Category? category { get; set; }
        public ICollection<ImageProduct>? images { get; set; }
        public ICollection<ProductsOfCart>? productsOfCart { get; set; }
        public ICollection<ProductsOfCategory>? productsOfCategories { get; set; }
    }
}
