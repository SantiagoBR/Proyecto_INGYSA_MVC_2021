using Proyecto_INGYSA_MVC_2021.Areas.ACADEMICO.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Proyecto_INGYSA_MVC_2021.Areas.PERSONAS.Data
{
    [Table("Acudiente")]
    public class Acudiente : Persona
    {
        //public int MatriculaId { get; set; }
        public virtual ICollection<Matricula> Matricula { get; set; }
    }
}