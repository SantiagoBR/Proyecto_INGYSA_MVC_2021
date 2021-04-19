using Proyecto_INGYSA_MVC_2021.Areas.COLEGIOS.Data.Metadata;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Proyecto_INGYSA_MVC_2021.Areas.COLEGIOS.Data
{
    [MetadataType(typeof(BloquesMetadata))]
    public class Bloques
    {
        public int BloquesId { get; set; }
        public string NombreBloque { get; set; }
        public int SedesId { get; set; }
        public Sedes Sedes { get; set; }

        // Un bloque puede tener 1_* Salones
        public virtual List<Salones> Salones { get; set; }
    }
}