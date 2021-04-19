using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_INGYSA_MVC_2021.Areas.PERSONAS.Data.MVVM
{
    public class DocenteVM:PersonaVM
    {
        public Docente Docente { get; set; }
        
        public List<Docente> docentes{ get; set; }
    }
}