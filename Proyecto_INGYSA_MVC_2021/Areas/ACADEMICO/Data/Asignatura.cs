using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_INGYSA_MVC_2021.Areas.ACADEMICO.Data
{
    public class Asignatura
    {
        public int AsignaturaId { get; set; }
        public string Descripcion { get; set; }
        public int CursoID { get; set; }

    }
}