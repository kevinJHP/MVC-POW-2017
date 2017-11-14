using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Brandingv1._0.Models
{
    public class referencias
    {
        [Key]


        public int referenciasID { get; set; }

        [Display(Name = "Persona")]
        public string persona { get; set; }

        [Display(Name = "telefono")]
        public int telefono { get; set; }

        [Display(Name = "Entidad")]
        public string entidad { get; set; }

        [Display(Name = "Puesto")]
        public string puesto { get; set; }
    }
}