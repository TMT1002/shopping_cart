using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Review
    {
        [Key]
        public int Id { get; set; }
        public uint rate { get; set; }
        public User? user { get; set; }
        public Product? product { get; set; }
    }
}
