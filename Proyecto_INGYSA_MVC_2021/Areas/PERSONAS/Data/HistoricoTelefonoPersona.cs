using Proyecto_INGYSA_MVC_2021.Areas.PERSONAS.Data.Metadata;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Proyecto_INGYSA_MVC_2021.Areas.PERSONAS.Data
{
    [MetadataType(typeof(HistoricoTelefonoPersonaMetadata))]
    public class HistoricoTelefonoPersona
    {
        public int HistoricoTelefonoPersonaId { get; set; }

        public TiposTelefono TiposTelefono { get; set; }
        public string Numero { get; set; }
        public bool Estado { get; set; }
        public int PersonaId { get; set; }

        /* Propiedades de navegación */
        public virtual Persona Persona { get; set; }

    }
}