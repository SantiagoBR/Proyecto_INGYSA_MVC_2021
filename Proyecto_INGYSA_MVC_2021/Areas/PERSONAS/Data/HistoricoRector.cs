using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Proyecto_INGYSA_MVC_2021.Areas.PERSONAS.Data
{
    [Table("HistoricoRector")]
    public class HistoricoRector
    {
        [Key]
        public int HistoricoRectorId { get; set; }
        public DateTime Fecha_Inicio { get; set; }
        public DateTime Fecha_Finalización { get; set; }
        public bool Estado { get; set; }
    }
}