using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proyecto_INGYSA_MVC_2021.Areas.ACADEMICO.Data
{
    [Table("Grados")]
    public class Grados
    {
        [Key]
        public int GradoID { get; set; }
        public string Descripcion { get; set; }
        public string Modalidad { get; set; }
        public string Nivel { get; set; }
        public int CursoId { get; set; }



    }
}