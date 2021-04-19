using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Proyecto_INGYSA_MVC_2021.Areas.PERSONAS.Data
{
    [Table("Docente")]
    public class Docente : Persona
    {

        [ForeignKey("Especialidad")]
        public int EspecialidadId { get; set; }

        public Especialidad Especialidad { get; set; }
    }
}