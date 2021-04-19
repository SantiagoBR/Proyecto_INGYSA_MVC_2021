using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_INGYSA_MVC_2021.Areas.PERSONAS.Data.MVVM
{
    public class PersonaVM
    {
        public HistoricoDocumentoPersona HistoricoDocumentoPersona { get; set; }
        public List<HistoricoDocumentoPersona> HistoricoDocumentoPersonas { get; set; }
        public HistoricoTelefonoPersona HistoricoTelefonoPersona { get; set; }
        public List<HistoricoTelefonoPersona> HistoricoTelefonoPersonas { get; set; }
        public HistoricoPersonaDireccion HistoricoPersonaDireccion { get; set; }
        public List<HistoricoPersonaDireccion> HistoricoPersonaDireccions { get; set; }
    }
}