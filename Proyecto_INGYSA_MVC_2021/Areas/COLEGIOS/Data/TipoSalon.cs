using Proyecto_INGYSA_MVC_2021.Areas.COLEGIOS.Data.Metadata;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Proyecto_INGYSA_MVC_2021.Areas.COLEGIOS.Data
{
    [MetadataType(typeof(TipoSalonMetadata))]
    [Table("TipoSalon")]
    public class TipoSalon
    {
        public int TipoSalonId { get; set; }
        public string Descripcion { get; set; }
    }
}