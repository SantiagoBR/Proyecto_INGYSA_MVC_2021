using Proyecto_INGYSA_MVC_2021.Areas.COLEGIOS.Data.Metadata;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Proyecto_INGYSA_MVC_2021.Areas.COLEGIOS.Data
{
    [MetadataType(typeof(PorteriasMetadata))]
    public class Porterias
    {
        public int PorteriasId { get; set; }
        public string NombrePorteria { get; set; }
        public bool Estado { get; set; }

        //Llave foranea
        public int SedesId { get; set; }
        public Sedes Sedes { get; set; }
    }
}