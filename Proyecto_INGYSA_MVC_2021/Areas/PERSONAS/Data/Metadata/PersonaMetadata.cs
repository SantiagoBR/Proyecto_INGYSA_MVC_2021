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
        [Required(ErrorMessage = "El Nombre es Obligatorio."),
        StringLength(30, ErrorMessage = "Ingrese un Nombre mas pequeño"), MinLength(3, ErrorMessage = "Nombre Muy Corto"),
        RegularExpression("(^[a-zA-ZÑÁÉÍÓÚñáéíóú /s]+$)", ErrorMessage = "Solo Ingrese Letras")]
        public string Nombres { get; set; }
        [Required(ErrorMessage = "El Apellido paterno es Obligatorio."),
        StringLength(50, ErrorMessage = "Ingrese un Apellido mas pequeño"),
        RegularExpression("(^[a-zA-ZÑÁÉÍÓÚñáéíóú /s]+$)", ErrorMessage = "Solo Ingrese Letras")]
        public string ApellidoP { get; set; }
        [Required(ErrorMessage = "El Apellido Materno es Obligatorio."),
        StringLength(50, ErrorMessage = "Ingrese un Apellido mas pequeño"),
        RegularExpression("(^[a-zA-ZÑÁÉÍÓÚñáéíóú /s]+$)", ErrorMessage = "Solo Ingrese Letras")]
        public string ApellidoM { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaNacimiento { get; set; }
        [Required(ErrorMessage = "Seleccione uno por favor")]
        public Genero Genero { get; set; }
        [Required(ErrorMessage = "Seleccione uno por favor")]
        public TipoSangre TipoSangre { get; set; }
        [Required(ErrorMessage = "Seleccione uno por favor")]
        public RH RH { get; set; }
    }
}