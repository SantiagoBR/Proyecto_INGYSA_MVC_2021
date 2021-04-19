using Proyecto_INGYSA_MVC_2021.Areas.PERSONAS.Data.Metadata;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Proyecto_INGYSA_MVC_2021.Areas.PERSONAS.Data
{
    [MetadataType(typeof(HistoricoDocumentoPersonaMetadata))]
    public class HistoricoDocumentoPersona
    {
        public int HistoricoDocumentoPersonaId { get; set; }
        public TipoDocumento TipoDocumento { get; set; }
        public string Numero { get; set; }
        public DateTime FechaExpedicion { get; set; }
        public bool Estado { get; set; }

        public int PersonaId { get; set; }

        /* propiedades de navegación */
        public virtual Persona Persona { get; set; }
    }
}