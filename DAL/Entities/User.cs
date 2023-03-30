using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public enum Role
    {
        ADMIN,
        USER
    }
    public class User
    {
        [Key]
        public int id { get; set; }
        [Required]
        [StringLength(50)]
        public string? userName { get; set; }
        [Required]
        public string? password { get; set; }
        [Required]
        public string? email { get; set; }
        [Required]
        public string? phoneNumber { get; set; }
        [DefaultValue(false)]
        public Boolean isActive { get; set; }
        public string? avatarLink { get; set; }
        public string? avatarName { get; set; }
        [DefaultValue(false)]
        public Boolean verifyContact { get; set; }
        [DefaultValue(false)]
        public Boolean verifyEmail { get; set; }
        [DefaultValue(Role.USER)]
        public Role role { get; set; }
        public string? verifyEmailToken { get; set; }
        public string? verifyContactToken { get; set; }
        public string? forgotPasswordToken { get; set; }
        public virtual ICollection<Token>? tokens {get; set; }
        public ICollection<Review>? reviews { get; set; }
        public ICollection<Order>? orders { get; set; }
        public ICollection<ProductsOfCart>? productsOfCart { get; set; }
    }
}
