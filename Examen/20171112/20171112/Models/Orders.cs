using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _20171112.Models
{
    public class Orders
    {
        [Key]
        [Display(Name = "Orden ID")]
        public int OrderID { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Datos de la orden")]
        public DateTime OrderDate { get; set; }

        [Required(ErrorMessage = "Usted debe de Ingresar un {0}")]
        [Display(Name = "Cliente ID")]
        public int CustomerID { get; set; }

        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        [Required(ErrorMessage = "Usted debe de Ingresar un {0}")]
        [Display(Name = "Total")]
        public decimal Total { get; set; }
    }
}