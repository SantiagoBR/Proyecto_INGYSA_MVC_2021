using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Proyecto_INGYSA_MVC_2021.Areas.PERSONAS.Data
{
    [Table("Rector")]
    public class Rector : Persona
    {
        public HistoricoRector HistoricoRector { get; set; }
    }
}