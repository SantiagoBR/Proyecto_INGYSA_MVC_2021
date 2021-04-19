using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Proyecto_INGYSA_MVC_2021.Areas.ACADEMICO.Data
{
    [Table("Cursos")]
    public class Cursos
    {
        [Key]
        public int CursoID { get; set; }
        public string NombreCurso { get; set; }

    }
}