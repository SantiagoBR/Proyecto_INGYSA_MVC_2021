using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Proyecto_INGYSA_MVC_2021.Areas.PERSONAS.Data.Metadata
{
    public class PersonaMetadata
    {
        [Key]
        [Column(Order = 1)]
        public int PersonaId { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio"),
        StringLength(30, ErrorMessage = "Ingrese un nombre mas pequeño"), MinLength(2, ErrorMessage = "Nombre Muy Corto"),
        RegularExpression("(^[a-zA-ZÑÁÉÍÓÚñáéíóú /s]+$)", ErrorMessage = "Solo ingrese letras")]
        public string Nombres { get; set; }
        [Required(ErrorMessage = "El apellido paterno es obligatorio"),
        StringLength(50, ErrorMessage = "Ingrese un apellido más pequeño"), MinLength(2, ErrorMessage = "Apellido Muy Corto"),
        RegularExpression("(^[a-zA-ZÑÁÉÍÓÚñáéíóú /s]+$)", ErrorMessage = "Solo ingrese lLetras")]
        public string ApellidoP { get; set; }
        [Required(ErrorMessage = "El apellido materno es obligatorio"),
        StringLength(50, ErrorMessage = "Ingrese un apellido más pequeño"), MinLength(2, ErrorMessage = "Apellido Muy Corto"),
        RegularExpression("(^[a-zA-ZÑÁÉÍÓÚñáéíóú /s]+$)", ErrorMessage = "Solo ingrese letras")]
        public string ApellidoM { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Fecha obligatoria")]
        public DateTime FechaNacimiento { get; set; }
        [Required(ErrorMessage = "Seleccione uno")]
        public Genero Genero { get; set; }
        [Required(ErrorMessage = "Seleccione uno")]
        public TipoSangre TipoSangre { get; set; }
        [Required(ErrorMessage = "Seleccione uno")]
        public RH RH { get; set; }
    }
}