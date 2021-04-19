using Proyecto_INGYSA_MVC_2021.Areas.COLEGIOS.Data.Metadata;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Proyecto_INGYSA_MVC_2021.Areas.COLEGIOS.Data
{
    [MetadataType(typeof(TiposEducacionMetadata))]
    [Table("TipoEducacion")]
    public class TipoEducacion
    {
        public int TipoEducacionId { get; set; }
        public string NombreTipoEducacion { get; set; }

        public virtual ICollection<Colegio> Colegio { get; set; }
    }
}