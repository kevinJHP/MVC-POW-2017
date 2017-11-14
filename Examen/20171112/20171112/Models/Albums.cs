using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _20171112.Models
{
    public class Albums
    {       
        [Key]
        [Display(Name = "Album ID")]
        public int AlbumId { get; set; }

        [Required(ErrorMessage = "Usted debe de Ingresar un {0}")]
        [Display(Name = "Genero ID")]
        public int GenreId { get; set; }

        [Required(ErrorMessage = "Usted debe de Ingresar un {0}")]
        [Display(Name = "Artista ID")]
        public int ArtistId { get; set; }
      
        [StringLength(160, ErrorMessage = "The field {0} must be between {2} and {1} characters", MinimumLength = 3)]
        [Required(ErrorMessage = "Usted debe de Ingresar un {0}")]
        [Display(Name = "Titulo")]
        public string Title { get; set; }

        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        [Required(ErrorMessage = "Usted debe de Ingresar un {0}")]
        [Display(Name = "Precio")]
        public decimal Price { get; set; }

        [StringLength(120, ErrorMessage = "The field {0} must be between {2} and {1} characters", MinimumLength = 3)]
        [Required(ErrorMessage = "Usted debe de Ingresar un {0}")]
        [Display(Name = "Url Arte del Album")]
        public string AlbumArtUrl { get; set; }


        //para hacer las relaciones con el mdelo de Genres y Artists
        public virtual Genres Genres { get; set; }
        public virtual Artists Artists { get; set; }

    }
}