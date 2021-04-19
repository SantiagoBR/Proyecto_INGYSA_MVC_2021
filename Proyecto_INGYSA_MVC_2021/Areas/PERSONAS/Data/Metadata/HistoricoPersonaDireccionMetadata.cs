using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Proyecto_INGYSA_MVC_2021.Areas.PERSONAS.Data.Metadata
{
    public class HistoricoPersonaDireccionMetadata
    {
        [Key]
        [Column(Order = 1)]
        public int HistoricoPersonaDireccionId { get; set; }
        [Required(ErrorMessage = "Direccion Requerida")]
        public string Direccion { get; set; }
        [ForeignKey("Persona")]
        public int PersonaId { get; set; }
    }
}