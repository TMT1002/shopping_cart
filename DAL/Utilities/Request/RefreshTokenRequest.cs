﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Utilities.Request
{
    public class RefreshTokenRequest
    {
        [Required]
        public string? refreshToken { get; set; }
        [Required]
        public int userId { get; set; }
    }
}
