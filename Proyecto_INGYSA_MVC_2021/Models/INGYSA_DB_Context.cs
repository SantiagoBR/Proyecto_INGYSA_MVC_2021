using Proyecto_INGYSA_MVC_2021.Areas.ACADEMICO.Data;
using Proyecto_INGYSA_MVC_2021.Areas.COLEGIOS.Data;
using Proyecto_INGYSA_MVC_2021.Areas.GENERAL.Data;
using Proyecto_INGYSA_MVC_2021.Areas.PERSONAS.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Proyecto_INGYSA_MVC_2021.Models
{
    public class INGYSA_DB_Context:IdentityDbContext
    {
        public INGYSA_DB_Context()
        {

        }
        public DbSet<Colegio> Colegios { get; set; }
        public DbSet<Bloques> Bloques { get; set; }
        public DbSet<Modalidad> Modalidad { get; set; }
        public DbSet<Porterias> Porterias { get; set; }
        public DbSet<Salones> Salones { get; set; }
        public DbSet<Sedes> Sedes { get; set; }
        public DbSet<TipoEducacion> TipoEducacion { get; set; }
        public DbSet<TipoSalon> TipoSalon { get; set; }
        public DbSet<Pais> Pais { get; set; }
        public DbSet<Ciudad> Ciudades { get; set; }
        public DbSet<Localidad> Localidades { get; set; }
        public DbSet<Barrio> Barrios { get; set; }
        public DbSet<Acudiente> Acudientes { get; set; }
        public DbSet<Coordinador> Coordinador { get; set; }
        public DbSet<Docente> Docentes { get; set; }
        public DbSet<Especialidad> Especialidad { get; set; }
        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<HistoricoDocumentoPersona> HistoricoDocumentoPersonas { get; set; }
        public DbSet<HistoricoPersonaDireccion> HistoricoPersonaDireccions { get; set; }
        public DbSet<HistoricoRector> HistoricoRector { get; set; }
        public DbSet<HistoricoTelefonoPersona> HistoricoTelefonoPersonas { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Personal> Personal { get; set; }
        public DbSet<Rector> Rectors { get; set; }
        public DbSet<TipoCoordinador> TipoCoordinador { get; set; }
        public DbSet<Vigilante> Vigilantes { get; set; }
        public DbSet<Asignatura> Asignaturas { get; set; }
        public DbSet<Cursos> Cursos { get; set; }
        public DbSet<Grados> Grados { get; set; }
        public DbSet<HistoricoCurso> HistoricoCursos { get; set; }
        public DbSet<Asistencia> Asistencias { get; set; }
        public DbSet<Jornada> Jornadas { get; set; }
        public DbSet<Matricula> Matriculas { get; set; }
        public DbSet<Lector_CB> Lector_CB { get; set; }
        public DbSet<Tarjeta> Tarjetas { get; set; }
    }
}