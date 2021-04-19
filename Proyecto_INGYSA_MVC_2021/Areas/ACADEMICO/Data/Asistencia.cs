using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_INGYSA_MVC_2021.Areas.ACADEMICO.Data
{
    public class Asistencia
    {
        public int asistenciaId { get; set; }
        public DateTime Fecha { get; set; }
        public string Justificacion { get; set; }

        public virtual List<Matricula> Matriculas { get; set; }
    }
}