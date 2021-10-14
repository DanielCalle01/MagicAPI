using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MagicAPI.Models
{
    public class Suerte
    {
        [Key]
        public string FutureId { get; set; }
        [Required(ErrorMessage = "{0} es requerido")]
        [StringLength(500, MinimumLength = 4, ErrorMessage = "La longitud de {0} debe estar entre {2} y {1}")]
        public string Vision { get; set; }
        [Url]
        [StringLength(1500, MinimumLength = 10, ErrorMessage = "La longitud de {0} debe estar entre {2} y {1}")]
        public string Imagen { get; set; }
    }
}
