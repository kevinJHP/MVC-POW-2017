using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _20171112.Models
{
    public class CustomerTypes
    {
        [Key]
        [Display(Name = "Cliente ID")]
        public int CustomerTypeID { get; set; }

        [StringLength(30, ErrorMessage = "The field {0} must be between {2} and {1} characters", MinimumLength = 3)]
        [Required(ErrorMessage = "Usted debe de Ingresar un {0}")]
        [Display(Name = "Tipo")]
        public string Type { get; set; }
    }
}