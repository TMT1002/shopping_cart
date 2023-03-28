using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class ProductsOfOrder
    {
        [Key]
        public int Id { get; set; }
        public int productId { get; set; }
        public string? name { get; set; }
        public string? thumbnailImage { get; set; }
        public string? brandName { get; set; }
        public string? description { get; set; }
        public int quantity { get; set; }
        public float discountPercent { get; set; }
        public float price { get; set; }
        public float totalPrice { get; set; }
        public Order? order { get; set; }
    }
}
