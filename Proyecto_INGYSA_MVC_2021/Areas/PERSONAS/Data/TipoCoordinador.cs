using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Proyecto_INGYSA_MVC_2021.Areas.PERSONAS.Data
{
    [Table("TipoCoordinador")]
    public class TipoCoordinador
    {
        public int TipoCoordinadorId { get; set; }
        public string NombreC { get; set; }

    }
}