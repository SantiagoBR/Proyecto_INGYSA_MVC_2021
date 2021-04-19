using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Proyecto_INGYSA_MVC_2021.Areas.COLEGIOS.Data.Metadata
{
    public class TiposEducacionMetadata
    {
        [Key]
        [Column(Order = 1)]
        public int TipoEducacionId { get; set; }
        [Required(ErrorMessage = "El nombre es requerido"),
         StringLength(50, ErrorMessage = "Máximo 50 caracteres"),
         MinLength(10, ErrorMessage = "Minimo 10 caracteres"),
         RegularExpression("(^[a-zA-ZÑÁÉÍÓÚzñáéíóú /s]+$)", ErrorMessage = "Solo Ingrese Letras")]
        public string NombreTipoEducacion { get; set; }
    }
}