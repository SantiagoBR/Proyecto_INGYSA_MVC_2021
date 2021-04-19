using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Proyecto_INGYSA_MVC_2021.Areas.ACADEMICO.Data
{
    public class Tarjeta
    {
        [Key]
        public int TarjetaId { get; set; }
        public virtual Matricula Matricula { get; set; }
    }
}