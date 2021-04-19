using Proyecto_INGYSA_MVC_2021.Areas.PERSONAS.Data.Metadata;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Proyecto_INGYSA_MVC_2021.Areas.PERSONAS.Data
{
    [MetadataType(typeof(HistoricoPersonaDireccionMetadata))]
    [Table("HistoricoPersonaDireccion")]
    public class HistoricoPersonaDireccion
    {
        public int HistoricoPersonaDireccionId { get; set; }
        public string Direccion { get; set; }
        public bool Estado { get; set; }


        public int PersonaId { get; set; }

        /* propiedades de navegación */
        public virtual Persona Persona { get; set; }


    }
}