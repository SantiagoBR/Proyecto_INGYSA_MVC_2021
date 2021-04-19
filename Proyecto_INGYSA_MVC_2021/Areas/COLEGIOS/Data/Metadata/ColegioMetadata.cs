using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Proyecto_INGYSA_MVC_2021.Areas.COLEGIOS.Data.Metadata
{
    public class ColegioMetadata
    {
        [Key]
        [Column(Order = 1)]
        public int ColegioId { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio"), StringLength(50), MinLength(3, ErrorMessage = "Mínimo {1} caracteres")]
        [RegularExpression("(^[a-zA-ZÑÁÉÍÓÚñáéíóú /s]+$)", ErrorMessage = "Solo Ingrese Letras")]
        public string Nombre { get; set; }

        [Required, StringLength(11, ErrorMessage = "El NIT debe tener 11 digitos")]
        [RegularExpression("(^[0-9]+-{1}[0-9]{1})", ErrorMessage = "El campo NIT debe ir asi: 000000000-0")]
        public string NIT { get; set; }

        [ForeignKey("TipoEducacion")]
        public int TipoEducacionId { get; set; }
    }
}