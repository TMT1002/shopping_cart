using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Token
    {
        [Key] 
        public int id { get; set; }
        [NotNull]
        public string? accessToken { get; set; }
        [NotNull]
        public string? refreshToken { get; set; }
        public User? user { get; set; }
    }
}
