using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Proyecto_INGYSA_MVC_2021.Areas.PERSONAS.Data
{
    [Table("Coordinador")]
    public class Coordinador : Persona
    {
        [Key]
        public int CoordinadorId { get; set; }
        [ForeignKey("TipoCoordinador")]
        public int TipoCoordinadorId { get; set; }
        public TipoCoordinador TipoCoordinador { get; set; }
    }
}