using Proyecto_INGYSA_MVC_2021.Areas.ACADEMICO.Data;
using Proyecto_INGYSA_MVC_2021.Areas.COLEGIOS.Data.Metadata;
using Proyecto_INGYSA_MVC_2021.Areas.GENERAL.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Proyecto_INGYSA_MVC_2021.Areas.COLEGIOS.Data
{
    [MetadataType(typeof(ColegioMetadata))]
    public class Colegio
    {
        [Key]
        public int ColegioId { get; set; }
        public string Nombre { get; set; }
        public string NIT { get; set; }



        //Fk
        public int BarrioId { get; set; }
        public int ModalidadId { get; set; }
        public int TipoEducacionId { get; set; }



        public virtual Barrio Barrio { get; set; }


        // Un colegio puede tener 1 o muchas sedes.
       

        public virtual TipoEducacion TipoEducacion { get; set; }

        public virtual Modalidad Modalidad{get; set;}

        
    }
}