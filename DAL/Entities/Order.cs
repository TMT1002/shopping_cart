using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public enum OrderStatus
    {
        PROCESSING,
        PENDING,
        SHIPPING
    }
    public class Order
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? address { get; set; }
        public Boolean isPaided { get; set; }
        public OrderStatus status { get; set; }
        public float totalPrice { get; set; }
        public User? user { get; set; }
        public PaymentMethod? paymentMethod { get; set; }
        public ICollection<VouchersOfOrder>? vouchersOfOrder { get; set; }
        public ICollection<ProductsOfOrder>? productsOfOder { get; set; }
    }
}
