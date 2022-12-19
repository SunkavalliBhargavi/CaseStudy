using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CropMVC.Models
{
    public class AdminViewModel
    {
        [Required(ErrorMessage ="*") ]
        public int ID { get; set; }
        [Required(ErrorMessage ="*") ]
        public string Email { get; set; }
        [Required(ErrorMessage ="*") ]
        public string Password { get; set; }
    }
}