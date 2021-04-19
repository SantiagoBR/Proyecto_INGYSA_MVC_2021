using Proyecto_INGYSA_MVC_2021.Areas.ACADEMICO.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Proyecto_INGYSA_MVC_2021.Areas.PERSONAS.Data
{
    [Table("Estudiante")]
    public class Estudiante : Persona
    {
        //[Key]
        //public int EstudianteId { get; set; }
        public virtual ICollection<Matricula> Matricula { get; set; }

    }
}