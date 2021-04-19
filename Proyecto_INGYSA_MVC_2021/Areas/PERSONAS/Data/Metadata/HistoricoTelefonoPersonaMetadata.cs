using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Proyecto_INGYSA_MVC_2021.Areas.PERSONAS.Data.Metadata
{
    public class HistoricoTelefonoPersonaMetadata
    {
        [Key]
        [Column(Order = 1)]
        public int HistoricoTelefonoPersonaId { get; set; }
        [Required(ErrorMessage = "Selecione Uno Por favor")]
        public TiposTelefono TiposTelefono { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "El número es requerido"),
        RegularExpression("(^[0-9]+$)", ErrorMessage = "Solo numeros")]
        [StringLength(10, ErrorMessage = "Maximo {1} caracteres")]
        [MinLength(7, ErrorMessage = "Minimo {1} caracteres")]
        public string Numero { get; set; }

        [ForeignKey("Persona")]
        public int PersonaId { get; set; }
    }
}