using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Proyecto_INGYSA_MVC_2021.Areas.GENERAL.Data.Metadata
{
    public class CiudadMetadata
    {
        [Key]
        [Column(Order = 1)]
        public int CiudadId { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio"), StringLength(50), MinLength(3, ErrorMessage = "Mínimo {1} caracteres")]
        [RegularExpression("(^[a-zA-ZÑÁÉÍÓÚñáéíóú /s]+$)", ErrorMessage = "Solo Ingrese Letras")]
        public string NombreCiudad { get; set; }

        //Llave foranea
        [ForeignKey("Pais")]
        public int PaisId { get; set; }
    }
}