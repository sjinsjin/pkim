using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace pkimupdate.Models
{
    public class Registration
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$", ErrorMessage = "Email format is not correct")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Mobile is required")]
        public string Mobile { get; set; }

        [Required(ErrorMessage = "Message is required")]
        public string Message { get; set; }
    }
}