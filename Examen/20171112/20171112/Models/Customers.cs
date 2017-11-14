using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _20171112.Models
{
    public class Customers
    {
        [Key]
        [Display(Name = "Cliente Id")]
        public int CustomersId { get; set; }

        [StringLength(160, ErrorMessage = "The field {0} must be between {2} and {1} characters", MinimumLength = 3)]
        [Required(ErrorMessage = "Usted debe de Ingresar un {0}")]
        [Display(Name = "Nombre")]
        public string FirstName { get; set; }

        [StringLength(160, ErrorMessage = "The field {0} must be between {2} and {1} characters", MinimumLength = 3)]
        [Required(ErrorMessage = "Usted debe de Ingresar un {0}")]
        [Display(Name = "Apellido")]
        public string LastName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Cumpleaños")]
        public DateTime DateOfBirth { get; set; }

        [StringLength(100, ErrorMessage = "The field {0} must be between {2} and {1} characters", MinimumLength = 3)]
        [Required(ErrorMessage = "Usted debe de Ingresar un {0}")]
        [Display(Name = "Direccion")]
        public string Address { get; set; }

        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        [Required(ErrorMessage = "Usted debe de Ingresar un {0}")]
        [Display(Name = "Sueldo")]
        public decimal Salary { get; set; }

        [StringLength(15, ErrorMessage = "The field {0} must be between {2} and {1} characters", MinimumLength = 3)]
        [Required(ErrorMessage = "Usted debe de Ingresar un {0}")]
        [Display(Name = "Telefono")]
        public string Phone { get; set; }


        [StringLength(250, ErrorMessage = "The field {0} must be between {2} and {1} characters", MinimumLength = 3)]
        [Required(ErrorMessage = "Usted debe de Ingresar un {0}")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Usted debe de Ingresar un {0}")]
        [Display(Name = "Tipo de Cliente ID")]
        public int CustomerTypeID { get; set; }

        [StringLength(20, ErrorMessage = "The field {0} must be between {2} and {1} characters", MinimumLength = 3)]
        [Required(ErrorMessage = "Usted debe de Ingresar un {0}")]
        [Display(Name = "Estado civil")]
        public string MaritalStatus { get; set; }

        [StringLength(35, ErrorMessage = "The field {0} must be between {2} and {1} characters", MinimumLength = 3)]
        [Required(ErrorMessage = "Usted debe de Ingresar un {0}")]
        [Display(Name = "Educacion")]
        public string Education { get; set; }

        [StringLength(45, ErrorMessage = "The field {0} must be between {2} and {1} characters", MinimumLength = 3)]
        [Required(ErrorMessage = "Usted debe de Ingresar un {0}")]
        [Display(Name = "Ocupacion")]
        public string Occupation { get; set; }

        [Required(ErrorMessage = "Usted debe de Ingresar un {0}")]
        [Display(Name = "Propiedades de Autos")]
        public int NumberCarsOwned { get; set; }

        [StringLength(1, ErrorMessage = "The field {0} must be between {2} and {1} characters", MinimumLength = 3)]
        [Required(ErrorMessage = "Usted debe de Ingresar un {0}")]
        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Usted debe de Ingresar un {0}")]
        [Display(Name = "Ubigeo ID")]
        public int UbigeoID { get; set; }

        public ICollection<Ubigeos> Ubigeos { get; set; }
    }
}