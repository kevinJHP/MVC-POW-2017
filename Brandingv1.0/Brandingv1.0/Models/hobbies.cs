using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Brandingv1._0.Models
{
    public class hobbies
    {
        [Key]


        public int estudiosID { get; set; }

        [Display(Name = "hobbie")]
        public string hobbie { get; set; }

        [Display(Name = "Descripción")]
        [DataType(DataType.MultilineText)]
        public string descripcion { get; set; }
    }
}