using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _20171112.Models
{
    public class Genres
    {
        [Key]
        [Display(Name = "Genero ID")]
        public int GenreId { get; set; }

        [StringLength(220, ErrorMessage = "The field {0} must be between {2} and {1} characters", MinimumLength = 3)]
        [Required(ErrorMessage = "Usted debe de Ingresar un {0}")]
        [Display(Name = "Nombre")]
        public string Name { get; set; }

        [StringLength(250, ErrorMessage = "The field {0} must be between {2} and {1} characters", MinimumLength = 3)]
        [Required(ErrorMessage = "Usted debe de Ingresar un {0}")]
        [Display(Name = "Descripcion")]
        public string Description { get; set; }

        public ICollection<Albums> Albums { get; set; }
    }
}