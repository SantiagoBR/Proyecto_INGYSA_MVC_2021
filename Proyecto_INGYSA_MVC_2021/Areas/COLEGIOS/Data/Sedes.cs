using Proyecto_INGYSA_MVC_2021.Areas.ACADEMICO.Data;
using Proyecto_INGYSA_MVC_2021.Areas.COLEGIOS.Data.Metadata;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Proyecto_INGYSA_MVC_2021.Areas.COLEGIOS.Data
{
    [MetadataType(typeof(SedesMetadata))]
    public class Sedes
    {
        public int SedesId { get; set; }
        public string NombreSede { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

        //Propiedades de llave Foranea
        public int ColegioId { get; set; }
        public virtual Colegio Colegio { get; set; }

        //Una sede puede tener 1 o muchos bloques
        public virtual List<Bloques> Bloques { get; set; }

        //Una sede puede tener 1 o muchas porterias
        public virtual List<Porterias> Porterias { get; set; }

        //Una sede puede tener 1 o muchas jornadas
        public virtual List<Jornada> Jornadas { get; set; }

    }
}