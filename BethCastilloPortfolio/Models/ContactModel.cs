﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BethCastilloPortfolio.Models
{
    public class ContactModel
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Subject is required")]
        public string Subject { get; set; }
        [Required(ErrorMessage = "Message is required")]
        public string Message { get; set; }
    }
}