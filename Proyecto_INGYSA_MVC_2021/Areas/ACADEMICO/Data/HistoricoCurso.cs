using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Proyecto_INGYSA_MVC_2021.Areas.ACADEMICO.Data
{
    [Table("HistoricoCurso")]
    public class HistoricoCurso
    {
        public int HistoricoCursoID { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public bool Estado { get; set; }
        public int CursoID { get; set; }
        public virtual ICollection<Matricula> Matricula { get; set; }

    }
}