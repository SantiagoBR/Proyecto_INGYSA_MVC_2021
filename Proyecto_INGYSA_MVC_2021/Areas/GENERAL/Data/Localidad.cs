using Proyecto_INGYSA_MVC_2021.Areas.GENERAL.Data.Metadata;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Proyecto_INGYSA_MVC_2021.Areas.GENERAL.Data
{
    [MetadataType(typeof(LocalidadMetadata))]
    [Table("Localidad")]
    public class Localidad
    {
        public int LocalidadId { get; set; }
        public string NombreLocalidad { get; set; }


        //Llave foranea
        public int CiudadId { get; set; }
        public Ciudad Ciudad { get; set; }
    }
}