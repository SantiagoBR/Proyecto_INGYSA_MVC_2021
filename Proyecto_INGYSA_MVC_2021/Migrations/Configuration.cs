namespace Proyecto_INGYSA_MVC_2021.Migrations
{
    using Proyecto_INGYSA_MVC_2021.Areas.COLEGIOS.Data;
    using Proyecto_INGYSA_MVC_2021.Areas.GENERAL.Data;
    using Proyecto_INGYSA_MVC_2021.Areas.PERSONAS.Data;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Proyecto_INGYSA_MVC_2021.Models.INGYSA_DB_Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(Proyecto_INGYSA_MVC_2021.Models.INGYSA_DB_Context context)
        {
            var especialidad = new List<Especialidad>
            {
                new Especialidad {Descripcion= "Matematicas"},
                new Especialidad {Descripcion="Edu fisica"},
                new Especialidad {Descripcion="Fisica"},
                new Especialidad {Descripcion="Quimica"},
                new Especialidad {Descripcion="Artes"}
            };
            especialidad.ForEach(e => context.Especialidad.AddOrUpdate(d => d.Descripcion, e));

            var pais = new List<Pais>
            {
                new Pais{NombrePais= "Colombia"},
                new Pais{NombrePais="Brazil"}
            };

            pais.ForEach(p=> context.Pais.AddOrUpdate(n => n.NombrePais, p));

            //var barr

            //var barrio = new List<Barrio>
            //{
            //    new Barrio{NombreBarrio="Castilla" ,LocalidadId=""}
            //};
            //barrio.ForEach(b => context.Barrios.AddOrUpdate(n => n.NombreBarrio, b));


            //var modalidad = new List<Modalidad>
            //{
            //    new Modalidad{Descripcion="Prescolar"},
            //    new Modalidad{Descripcion="Básica"},
            //    new Modalidad{Descripcion="Secundaria"},
            //    new Modalidad{Descripcion="Bachiller"}
            //};
            //modalidad.ForEach(m => context.Modalidad.AddOrUpdate(d => d.Descripcion, m));


            context.SaveChanges();
        }
    }
}
