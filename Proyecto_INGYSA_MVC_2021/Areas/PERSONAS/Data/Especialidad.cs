using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Proyecto_INGYSA_MVC_2021.Areas.PERSONAS.Data
{
    [Table("Especialidad")]
    public class Especialidad
    {
        [Key]
        public int EspecialidadId { get; set; }
        public string Descripcion { get; set; }


       // public List<Docente> docentes { get; set; }
    }
}