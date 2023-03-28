using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Voucher
    {
        [Key]
        public int Id { get; set; }
        public string? content { get; set; }
        public float value { get; set; }
        public DateTime expriseTime { get; set; }
        public int quantity { get; set; }
        public int used { get; set; }
        public ICollection<VouchersOfOrder>? vouchersOfOrder { get; set; }
    }
}
