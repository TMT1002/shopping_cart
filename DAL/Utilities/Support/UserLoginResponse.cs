using DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Utilities.Support
{
    public class UserLoginResponse
    {
        public int id { get; set; }
        public string? userName { get; set; }
        public string? email { get; set; }
        public string? phoneNumber { get; set; }
        public Boolean isActive { get; set; }
        public string? avatarLink { get; set; }
        public string? avatarName { get; set; }
        [DefaultValue(false)]
        public Boolean verifyContact { get; set; }
        public Boolean verifyEmail { get; set; }
        public Role role { get; set; }
    }
}
