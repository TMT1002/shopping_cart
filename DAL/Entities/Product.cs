﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        [DefaultValue(0)]
        public float rateAvgReview { get; set; }
        public string? thumbnailImage { get; set; }
        public string? thumbnailImgName { get; set; }
        public ICollection<Review>? reviews { get; set; }
        public int categoryId { get; set; }
        [Required]
        public virtual Category? category { get; set; }
        public ICollection<ImageProduct>? images { get; set; }
        public ICollection<ProductsOfCart>? productsOfCart { get; set; }
        public ICollection<ProductsOfCategory>? productsOfCategories { get; set; }
    }
}
