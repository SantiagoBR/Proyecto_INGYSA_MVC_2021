using Proyecto_INGYSA_MVC_2021.Areas.COLEGIOS.Data.Metadata;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Proyecto_INGYSA_MVC_2021.Areas.COLEGIOS.Data
{
    [MetadataType(typeof(ModalidadMetadata))]
    [Table("Modalidad")]
    public class Modalidad
    {
        public int ModalidadId { get; set; }

        public string Descripcion { get; set; }

   
    }
}