using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string? nameCategory { get; set; }
        public ICollection<Product>? products { get; set; }
        public ICollection<ProductsOfCategory>? productsOfCategories { get; set; }
    }
}
