using Proyecto_INGYSA_MVC_2021.Areas.GENERAL.Data.Metadata;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Proyecto_INGYSA_MVC_2021.Areas.GENERAL.Data
{
    [MetadataType(typeof(CiudadMetadata))]
    [Table("Ciudad")]
    public class Ciudad
    {
        public int CiudadId { get; set; }
        public string NombreCiudad { get; set; }

        //Llave foranea
        public int PaisId { get; set; }
        public Pais Pais { get; set; }
    }
}