using Proyecto_INGYSA_MVC_2021.Areas.COLEGIOS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_INGYSA_MVC_2021.Areas.ACADEMICO.Data
{
    public class Jornada
    {
        public int JornadaId { get; set; }
        public string NombreJ { get; set; }
        public virtual Sedes Sedes { get; set; }
        public virtual ICollection<Matricula> Matricula { get; set; }
    }
}