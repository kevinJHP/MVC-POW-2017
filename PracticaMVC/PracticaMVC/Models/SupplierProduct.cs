using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PracticaMVC.Models
{
    public class SupplierProduct
    {
        [Key]
        public int SupplierProductID { get; set; }
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        [Required(ErrorMessage = "Usted debe de Ingresar un {0}")]
        public decimal Price { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Last Buy")]
        public DateTime LastBuy { get; set; }


        public int SupplierID { get; set; }
        public int ProductID { get; set; }

        //para hacer las relaciones con el mdelo de Supplier
        public virtual Supplier Supplier { get; set; }

        //para hacer las relaciones con el mdelo de Product
        public virtual Product Product { get; set; }

    }
}