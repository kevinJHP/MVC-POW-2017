﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Brandingv1._0.Models
{
    public class estudios
    {
        [Key]
        
        
        public int estudiosID { get; set; }
        
        [Display(Name = "Institución")]     
        public string institucion { get; set; }

        [Display(Name = "Especialidad")]
        public string especialidad { get; set; }

        [Display(Name = "Fecha de Inicio")]
        [DataType(DataType.Date)]
        public DateTime fechaini { get; set; }

        [Display(Name = "Fecha Final")]
        [DataType(DataType.Date)]
        public DateTime fechafin { get; set; }
    }
}