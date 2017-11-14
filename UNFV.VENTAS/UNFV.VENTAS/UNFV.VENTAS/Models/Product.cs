using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UNFV.VENTAS.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
    
        [Display(Name = "Nombre del Producto")]
        [Required(ErrorMessage = "Usted debe de Ingresar textos")]
        [StringLength(35, ErrorMessage = "Estas ingresando mas de 35 caracteres", MinimumLength = 3)]
        public string Name { get; set; }

        [Display(Name = "Lista de Precios")]
        [Required(ErrorMessage = "Usted debe de Ingresar números")]
        [DisplayFormat(DataFormatString = "{0:C4}",ApplyFormatInEditMode= false)]
        public decimal listPrice { get; set; } //lista de precios

        [Display(Name = "Ultima Compra")]
        [Required(ErrorMessage = "Usted debe de Ingresar una fecha")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime LastBuy { get; set; } //ultima compra

        [Display(Name = "Lista de Stock")]
        [Required(ErrorMessage = "Usted debe de Ingresar números")]
        [DisplayFormat(DataFormatString = "{0:C4}", ApplyFormatInEditMode = false)]
        public float Stock { get; set; }
        
        public string Remarks { get; set; } //comentarios
        public string Suppliers { get; set; } //complementos
   }
}