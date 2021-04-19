using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_INGYSA_MVC_2021.Areas.PERSONAS.Data.MVVM
{
    public class EstudianteVM:PersonaVM
    {
        public Estudiante Estudiante { get; set; }
        public List<Estudiante> estudiantes { get; set; }
       
    }
}