using Proyecto_INGYSA_MVC_2021.Areas.GENERAL.Data.Metadata;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Proyecto_INGYSA_MVC_2021.Areas.GENERAL.Data
{
    [MetadataType(typeof(BarrioMetadata))]
    public class Barrio
    {
        public int BarrioId { get; set; }
        public string NombreBarrio { get; set; }

        //Llave foranea
        public int LocalidadId { get; set; }
        public Localidad Localidad { get; set; }
    }
}