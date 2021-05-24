using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Proyecto_INGYSA_MVC_2021.Areas.PERSONAS.Data.Metadata
{
    public class HistoricoDocumentoPersonaMetadata
    {
        [Key]
        [Column(Order = 1)]
        public int HistoricoDocumentoPersonaId { get; set; }
        [Required(ErrorMessage = "Seleccione uno")]
        public TipoDocumento TipoDocumento { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "El número es requerido"), RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo numeros")]
        [StringLength(10, ErrorMessage = "Maximo {1} caracteres")]
        [MinLength(6, ErrorMessage = "Minimo {1} caracteres")]
        public string Numero { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Fecha obligatoria")]
        public DateTime FechaExpedicion { get; set; }

        [ForeignKey("Persona")]
        public int PersonaId { get; set; }
    }
}