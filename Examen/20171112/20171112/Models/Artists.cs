using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _20171112.Models
{
    public class Artists
    {
        [Key]
        [Display(Name = "Artista Id")]
        public int ArtistId { get; set; }

        [StringLength(150, ErrorMessage = "The field {0} must be between {2} and {1} characters", MinimumLength = 3)]
        [Required(ErrorMessage = "Usted debe de Ingresar un {0}")]
        [Display(Name = "Nombre del Artista")]
        public string Name { get; set; }
        
        
        public ICollection<Albums> Albums { get; set; }
    }
}