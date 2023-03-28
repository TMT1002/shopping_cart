using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class ProductsOfCart
    {
        [Key]
        public int Id { get; set; }
        public int quantity { get; set; }
        public int price { get; set; }
        public int totalPrice { get; set; }
        public User? user { get; set; }
        public Product? product { get; set; }
    }
}
