using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class VouchersOfOrder
    {
        [Key]
        public int Id { get; set; }
        public string? name { get; set; }
        public float value { get; set; }
        public Voucher? voucher { get; set; }
        public Order? order { get; set; }
    }
}
