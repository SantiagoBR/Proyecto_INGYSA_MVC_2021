using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Proyecto_INGYSA_MVC_2021.Areas.COLEGIOS.Data.Metadata
{
    public class TipoSalonMetadata
    {
        [Key]
        [Column(Order = 1)]
        public int TipoSalonId { get; set; }
        [Required(ErrorMessage = "la Descripción es requerida"),
         StringLength(100, ErrorMessage = "Máximo 100 caracteres"),
         MinLength(20, ErrorMessage = "Minimo 20 caracteres")]
        public string Descripcion { get; set; }
    }
}