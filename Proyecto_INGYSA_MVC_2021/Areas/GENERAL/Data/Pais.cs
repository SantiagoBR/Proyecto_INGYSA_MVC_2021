using Proyecto_INGYSA_MVC_2021.Areas.GENERAL.Data.Metadata;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Proyecto_INGYSA_MVC_2021.Areas.GENERAL.Data
{
    [MetadataType(typeof(PaisMetadata))]
    public class Pais
    {
        public int PaisId { get; set; }
        public string NombrePais { get; set; }
    }
}