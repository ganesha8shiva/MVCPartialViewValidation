using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcApplication1.Models
{
    public class AddUserViewModel
    {
        [Required(ErrorMessage = "Please enter name !!!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter email address !!!")]
        [EmailAddress(ErrorMessage = "Please enter valid email address !!!")]
        public string Email { get; set; }
    }
}