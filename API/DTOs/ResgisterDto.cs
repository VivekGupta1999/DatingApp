﻿using System;
using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
	public class ResgisterDto
	{
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}

