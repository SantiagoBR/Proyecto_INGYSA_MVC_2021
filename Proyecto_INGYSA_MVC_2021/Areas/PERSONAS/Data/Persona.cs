using Proyecto_INGYSA_MVC_2021.Areas.PERSONAS.Data.Metadata;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Proyecto_INGYSA_MVC_2021.Areas.PERSONAS.Data
{
    [MetadataType(typeof(PersonaMetadata))]
    public class Persona
    {
        public int PersonaId { get; set; }
        public string Nombres { get; set; }
        public string ApellidoP { get; set; }
        public string ApellidoM { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public Genero Genero { get; set; }
        public TipoSangre TipoSangre { get; set; }
        public RH RH { get; set; }
        public bool Estado { get; set; }

        //propiedades de navegación
        public virtual ICollection<HistoricoDocumentoPersona> HistoricoDocumentoPersona { get; set; }
        public virtual ICollection<HistoricoTelefonoPersona> HistoricoTelefonosPersona { get; set; }
        public virtual ICollection<HistoricoPersonaDireccion> HistoricoPersonaDireccion { get; set; }

    }
}