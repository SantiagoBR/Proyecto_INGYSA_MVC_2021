using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Proyecto_INGYSA_MVC_2021.Areas.GENERAL.Data.Metadata
{
    public class LocalidadMetadata
    {
        [Key]
        [Column(Order = 1)]
        public int LocalidadId { get; set; }
        public string NombreLocalidad { get; set; }


        //Llave foranea
        [ForeignKey("Ciudad")]
        public int CiudadId { get; set; }
    }
}