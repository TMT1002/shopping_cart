using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class ProductsOfCategory
    {
        [Key]
        public int Id { get; set; }
        public Product? product { get; set; }
        public Category? category { get; set; }

    }
}
