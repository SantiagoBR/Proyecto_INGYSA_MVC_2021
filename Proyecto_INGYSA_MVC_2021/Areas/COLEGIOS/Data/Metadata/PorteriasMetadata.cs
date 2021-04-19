using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Proyecto_INGYSA_MVC_2021.Areas.COLEGIOS.Data.Metadata
{
    public class PorteriasMetadata
    {
        [Key]
        [Column(Order = 1)]
        public int PorteriasId { get; set; }
        [StringLength(50, ErrorMessage = "Máximo 50 caracteres"),
         MinLength(10, ErrorMessage = "Minimo 10 caracteres"),
         RegularExpression("(^[a-zA-ZÑÁÉÍÓÚ /s]+$)", ErrorMessage = "Solo Ingrese Letras")]
        public string NombrePorteria { get; set; }

        public bool Estado { get; set; }

        //Llave foranea
        [ForeignKey("Sedes")]
        public int SedesId { get; set; }
    }
}