using Proyecto_INGYSA_MVC_2021.Areas.COLEGIOS.Data.Metadata;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Proyecto_INGYSA_MVC_2021.Areas.COLEGIOS.Data
{
    [MetadataType(typeof(SalonesMetadata))]
    public class Salones
    {
        public int SalonesId { get; set; }
        public string NombreSalon { get; set; }
        public bool Estado { get; set; }

        //Llave Foranea

        public int BloquesId { get; set; }
        public virtual Bloques Bloques { get; set; }


        public int TipoSalonId { get; set; }
        public virtual TipoSalon TipoSalon { get; set; }

    }
}