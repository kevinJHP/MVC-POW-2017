using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _20171112.Models
{
    public class OrderDetails
    {
        [Key]
        [Display(Name = "Detalle de Orden ID")]
        public int OrderDetailID { get; set; }

        [Required(ErrorMessage = "Usted debe de Ingresar un {0}")]
        [Display(Name = "Orden ID")]
        public int OrderID { get; set; }

        [Required(ErrorMessage = "Usted debe de Ingresar un {0}")]
        [Display(Name = "Album ID")]
        public int AlbumId { get; set; }

        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        [Required(ErrorMessage = "Usted debe de Ingresar un {0}")]
        [Display(Name = "Precio")]
        public decimal Price { get; set; }

        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        [Required(ErrorMessage = "Usted debe de Ingresar un {0}")]
        [Display(Name = "Cantidad")]
        public decimal Quantity { get; set; }

        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        [Required(ErrorMessage = "Usted debe de Ingresar un {0}")]
        [Display(Name = "Subtotal")]
        public decimal SubTotal { get; set; }
    }
}