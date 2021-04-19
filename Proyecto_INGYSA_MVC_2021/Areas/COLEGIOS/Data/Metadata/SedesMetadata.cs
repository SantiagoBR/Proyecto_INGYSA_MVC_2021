using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Proyecto_INGYSA_MVC_2021.Areas.COLEGIOS.Data.Metadata
{
    public class SedesMetadata
    {
        [Key]
        [Column(Order = 1)]
        public int SedesId { get; set; }

        [Required(ErrorMessage = "El nombre es requerido"),
         StringLength(50, ErrorMessage = "Máximo 50 caracteres"),
         MinLength(10, ErrorMessage = "Minimo 10 caracteres"),
         RegularExpression("(^[a-zA-ZÑÁÉÍÓÚ /s]+$)", ErrorMessage = "Solo Ingrese Letras")]
        public string NombreSede { get; set; }
        [Required(ErrorMessage = "La dirección es obligatoria"), StringLength(50), MinLength(10, ErrorMessage = "Mínimo {1} caracteres")]
        public string Direccion { get; set; }

        [RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo Ingrese Numeros")]
        [MaxLength(10, ErrorMessage = "Maximo {1} números"), MinLength(7, ErrorMessage = "Minímo {1} números")]
        public string Telefono { get; set; }

        //Llave Foranea
        [ForeignKey("Colegio")]
        public int ColegioId { get; set; }
    }
}