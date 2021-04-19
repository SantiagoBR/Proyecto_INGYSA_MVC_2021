using Proyecto_INGYSA_MVC_2021.Areas.PERSONAS.Data;
using Proyecto_INGYSA_MVC_2021.Areas.PERSONAS.Data.MVVM;
using Proyecto_INGYSA_MVC_2021.Models;
using Proyecto_INGYSA_MVC_2021.Models.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_INGYSA_MVC_2021.Areas.PERSONAS.Logica_Negocio
{
    public class Estudiante_Negocio
    {
        private DBRepository dBRepository;
        public Estudiante_Negocio()
        {
            dBRepository = new DBRepository(new INGYSA_DB_Context());
        }

        Estudiante estudiante = new Estudiante();
        HistoricoDocumentoPersona historicoDocumento = new HistoricoDocumentoPersona();
        HistoricoTelefonoPersona historicoTelefono = new HistoricoTelefonoPersona();
        HistoricoPersonaDireccion personaDireccion = new HistoricoPersonaDireccion();

        public void CrearEstudiante(EstudianteVM estudianteVM)
        {
            estudiante.Nombres = estudianteVM.Estudiante.Nombres;
            estudiante.ApellidoP = estudianteVM.Estudiante.ApellidoP;
            estudiante.ApellidoM = estudianteVM.Estudiante.ApellidoM;
            estudiante.FechaNacimiento = estudianteVM.Estudiante.FechaNacimiento;
            estudiante.Genero = estudianteVM.Estudiante.Genero;
            estudiante.RH = estudianteVM.Estudiante.RH;
            estudiante.TipoSangre = estudianteVM.Estudiante.TipoSangre;
            estudiante.Estado = estudianteVM.Estudiante.Estado;

            historicoDocumento.PersonaId = estudiante.PersonaId;
            historicoDocumento.FechaExpedicion = estudianteVM.HistoricoDocumentoPersona.FechaExpedicion;
            historicoDocumento.TipoDocumento = estudianteVM.HistoricoDocumentoPersona.TipoDocumento;
            historicoDocumento.Numero = estudianteVM.HistoricoDocumentoPersona.Numero;
            historicoTelefono.Estado = estudianteVM.HistoricoDocumentoPersona.Estado;

            historicoTelefono.PersonaId = estudiante.PersonaId;
            historicoTelefono.TiposTelefono = estudianteVM.HistoricoTelefonoPersona.TiposTelefono;
            historicoTelefono.Numero = estudianteVM.HistoricoTelefonoPersona.Numero;
            historicoTelefono.Estado = estudianteVM.HistoricoTelefonoPersona.Estado;

            personaDireccion.PersonaId = estudiante.PersonaId;
            personaDireccion.Direccion = estudianteVM.HistoricoPersonaDireccion.Direccion;
            personaDireccion.Estado = estudianteVM.HistoricoPersonaDireccion.Estado;

            dBRepository.Add(estudiante);
            dBRepository.Add(historicoDocumento);
            dBRepository.Add(historicoTelefono);
            dBRepository.Add(personaDireccion);
            dBRepository.Commit();

        }

        public EstudianteVM Edit(int? Id, EstudianteVM estudiantevm)
        {
            var estudiantes = dBRepository.GetAll<Estudiante>();
            var Documentos = dBRepository.GetAll<HistoricoDocumentoPersona>();
            var telefonos = dBRepository.GetAll<HistoricoTelefonoPersona>();
            var Direccion = dBRepository.GetAll<HistoricoPersonaDireccion>();

            var person = from p in estudiantes
                         join d in Documentos on p.PersonaId equals d.PersonaId
                         join dir in Direccion on p.PersonaId equals dir.PersonaId
                         join tel in telefonos on p.PersonaId equals tel.PersonaId
                         where p.PersonaId == Id
                         select new
                         {
                             PersonaId = p.PersonaId,
                             Nombres = p.Nombres,
                             ApellidoP = p.ApellidoP,
                             ApellidoM = p.ApellidoM,
                             FechaNacimiento = p.FechaNacimiento,
                             Genero = p.Genero,
                             TipoSangre = p.TipoSangre,
                             RH = p.RH,
                             Estado = p.Estado,
                             historicoDocumentoid = d.HistoricoDocumentoPersonaId,
                             TipoDocumento = d.TipoDocumento,
                             Numero = d.Numero,
                             FechaExpedicion = d.FechaExpedicion,
                             estado = d.Estado,
                             historicoTelefonoid=tel.HistoricoTelefonoPersonaId,
                             TiposTelefono = tel.TiposTelefono,
                             numero = tel.Numero,
                             historicodireccionid=dir.HistoricoPersonaDireccionId,
                             Direccion = dir.Direccion
                         };

            var query = person.FirstOrDefault(x => x.PersonaId == Id);


            estudiante.PersonaId = query.PersonaId;
            estudiante.Nombres = query.Nombres;
            estudiante.ApellidoP = query.ApellidoP;
            estudiante.ApellidoM = query.ApellidoM;
            estudiante.FechaNacimiento = query.FechaNacimiento;
            estudiante.Genero = query.Genero;
            estudiante.RH = query.RH;
            estudiante.TipoSangre = query.TipoSangre;
            estudiante.Estado = query.Estado;


            historicoDocumento.HistoricoDocumentoPersonaId = query.historicoDocumentoid;
            historicoDocumento.PersonaId = query.PersonaId;
            historicoDocumento.TipoDocumento = query.TipoDocumento;
            historicoDocumento.FechaExpedicion = query.FechaExpedicion;
            historicoDocumento.Numero = query.Numero;
            historicoDocumento.Estado = query.Estado;

            historicoTelefono.HistoricoTelefonoPersonaId = query.historicoTelefonoid;
            historicoTelefono.PersonaId = query.PersonaId;
            historicoTelefono.TiposTelefono = query.TiposTelefono;
            historicoTelefono.Numero = query.Numero;
            historicoTelefono.Estado = query.Estado;

            personaDireccion.HistoricoPersonaDireccionId = query.historicodireccionid;
            personaDireccion.PersonaId = query.PersonaId;
            personaDireccion.Direccion = query.Direccion;
            personaDireccion.Estado = query.Estado;


            estudiantevm.Estudiante = estudiante;
            estudiantevm.HistoricoDocumentoPersona = historicoDocumento;
            estudiantevm.HistoricoTelefonoPersona = historicoTelefono;
            estudiantevm.HistoricoPersonaDireccion = personaDireccion;



            return estudiantevm;
        }

        public void UpdateEstudiante(EstudianteVM estudianteVM, int id)
        {
            estudiante.PersonaId = id;
            estudiante.Nombres = estudianteVM.Estudiante.Nombres;
            estudiante.ApellidoP = estudianteVM.Estudiante.ApellidoP;
            estudiante.ApellidoM = estudianteVM.Estudiante.ApellidoM;
            estudiante.FechaNacimiento = estudianteVM.Estudiante.FechaNacimiento;
            estudiante.Genero = estudianteVM.Estudiante.Genero;
            estudiante.RH = estudianteVM.Estudiante.RH;
            estudiante.TipoSangre = estudianteVM.Estudiante.TipoSangre;
            estudiante.Estado = estudianteVM.Estudiante.Estado;

            historicoDocumento.PersonaId = estudiante.PersonaId;
            historicoDocumento.HistoricoDocumentoPersonaId = estudianteVM.HistoricoDocumentoPersona.HistoricoDocumentoPersonaId;
            historicoDocumento.TipoDocumento = estudianteVM.HistoricoDocumentoPersona.TipoDocumento;
            historicoDocumento.FechaExpedicion = estudianteVM.HistoricoDocumentoPersona.FechaExpedicion;
            historicoDocumento.Numero = estudianteVM.HistoricoDocumentoPersona.Numero;
            historicoDocumento.Estado = estudianteVM.HistoricoDocumentoPersona.Estado;

            historicoTelefono.PersonaId = estudiante.PersonaId;
            historicoTelefono.HistoricoTelefonoPersonaId = estudianteVM.HistoricoTelefonoPersona.HistoricoTelefonoPersonaId;
            historicoTelefono.TiposTelefono = estudianteVM.HistoricoTelefonoPersona.TiposTelefono;
            historicoTelefono.Numero = estudianteVM.HistoricoTelefonoPersona.Numero;
            historicoTelefono.Estado = estudianteVM.HistoricoTelefonoPersona.Estado;

            personaDireccion.PersonaId = estudiante.PersonaId;
            personaDireccion.HistoricoPersonaDireccionId = estudianteVM.HistoricoPersonaDireccion.HistoricoPersonaDireccionId;
            personaDireccion.Direccion = estudianteVM.HistoricoPersonaDireccion.Direccion;
            personaDireccion.Estado = estudianteVM.HistoricoPersonaDireccion.Estado;

            dBRepository.Update(estudiante);
            dBRepository.Update(historicoDocumento);
            dBRepository.Update(historicoTelefono);
            dBRepository.Update(personaDireccion);
            dBRepository.Commit();

        }



    }
}