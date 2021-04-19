using Proyecto_INGYSA_MVC_2021.Areas.COLEGIOS.Data;
using Proyecto_INGYSA_MVC_2021.Areas.PERSONAS.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Proyecto_INGYSA_MVC_2021.Areas.ACADEMICO.Data
{
    [Table("Matricula")]
    public class Matricula
    {
        public Matricula() { }

        [Key]
        [Required]
        public int MatriculaId { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public bool Estado { get; set; }
        [ForeignKey("Estudiante")]
        public int PersonaId { get; set; }
        [ForeignKey("Tarjeta")]
        public int TarjetaId { get; set; }
        [ForeignKey("HistoricoCurso")]
        public int HistoricoCursoId { get; set; }
        [ForeignKey("Jornada")]
        public int JornadaId { get; set; }
        [ForeignKey("Colegio")]
        public int ColegioId { get; set; }
        [ForeignKey("Acudiente")]
        public int AcudienteId { get; set; }

        public virtual List<Asistencia> Asistencias { get; set; }
        public virtual List<Tarjeta> Tarjeta { get; set; }
        public virtual Estudiante Estudiante { get; set; }
        public virtual Acudiente Acudiente { get; set; }
        public virtual Jornada Jornada { get; set; }
        public virtual Colegio Colegio { get; set; }

        public virtual HistoricoCurso HistoricoCurso { get; set; }

    }
}