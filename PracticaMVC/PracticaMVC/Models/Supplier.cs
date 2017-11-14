using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PracticaMVC.Models
{
    public class Supplier
    {
        [Key]
        public int SupplierID { get; set; }

        [StringLength(30, ErrorMessage = "The field {0} must be between {2} and {1} characters", MinimumLength = 3)]
        [Required(ErrorMessage = "Usted debe de Ingresar un {0}")]
        [Display(Name = "Supplier Name")]
        public string Name { get; set; }

        [StringLength(30, ErrorMessage = "The field {0} must be between {2} and {1} characters", MinimumLength = 3)]
        [Required(ErrorMessage = "Usted debe de Ingresar un {0}")]
        [Display(Name = "Contact First Name")]
        public string ContactFirstName { get; set; }

        [StringLength(30, ErrorMessage = "The field {0} must be between {2} and {1} characters", MinimumLength = 3)]
        [Required(ErrorMessage = "Usted debe de Ingresar un {0}")]
        [Display(Name = "Contact Last Name")]
        public string ContactLastName { get; set; }

        [DataType(DataType.PhoneNumber)]
        [StringLength(30, ErrorMessage = "The field {0} must be between {2} and {1} characters", MinimumLength = 3)]
        [Required(ErrorMessage = "Usted debe de Ingresar un {0}")]
        public string Phone { get; set; }

        [StringLength(30, ErrorMessage = "The field {0} must be between {2} and {1} characters", MinimumLength = 3)]
        [Required(ErrorMessage = "Usted debe de Ingresar un {0}")]
        public string Address { get; set; }

        [DataType(DataType.EmailAddress)]
        public string EMail { get; set; }

        //Relacion de muchos a uno
        public ICollection<SupplierProduct> SupplierProducts { get; set; }

    }
}