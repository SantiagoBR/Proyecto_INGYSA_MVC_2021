using Proyecto_INGYSA_MVC_2021.Models;
using Proyecto_INGYSA_MVC_2021.Areas.PERSONAS.Data;
using Proyecto_INGYSA_MVC_2021.Models.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Proyecto_INGYSA_MVC_2021.Areas.PERSONAS.Data.MVVM;

namespace Proyecto_INGYSA_MVC_2021.Areas.PERSONAS.Logica_Negocio
{
    public class Docente_Negocio
    {
        private DBRepository dBRepository;

        public Docente_Negocio()
        {
            dBRepository = new DBRepository(new INGYSA_DB_Context());
        }

        Docente docente = new Docente();
        HistoricoDocumentoPersona historicoDocumento = new HistoricoDocumentoPersona();
        HistoricoTelefonoPersona historicoTelefono = new HistoricoTelefonoPersona();
        HistoricoPersonaDireccion personaDireccion = new HistoricoPersonaDireccion();
        

        public void CrearDocente(DocenteVM docenteVM)
        {
            docente.Nombres = docenteVM.Docente.Nombres;
            docente.ApellidoP = docenteVM.Docente.ApellidoP;
            docente.ApellidoM = docenteVM.Docente.ApellidoM;
            docente.FechaNacimiento = docenteVM.Docente.FechaNacimiento;
            docente.Genero = docenteVM.Docente.Genero;
            docente.RH = docenteVM.Docente.RH;
            docente.TipoSangre = docenteVM.Docente.TipoSangre;
            docente.Estado = docenteVM.Docente.Estado;

            docente.EspecialidadId = docenteVM.Docente.EspecialidadId;
         
            

            historicoDocumento.PersonaId = docente.PersonaId;
            historicoDocumento.FechaExpedicion = docenteVM.HistoricoDocumentoPersona.FechaExpedicion;
            historicoDocumento.TipoDocumento = docenteVM.HistoricoDocumentoPersona.TipoDocumento;
            historicoDocumento.Numero = docenteVM.HistoricoDocumentoPersona.Numero;
            historicoTelefono.Estado = docenteVM.HistoricoDocumentoPersona.Estado;

            historicoTelefono.PersonaId = docente.PersonaId;
            historicoTelefono.TiposTelefono = docenteVM.HistoricoTelefonoPersona.TiposTelefono;
            historicoTelefono.Numero = docenteVM.HistoricoTelefonoPersona.Numero;
            historicoTelefono.Estado = docenteVM.HistoricoTelefonoPersona.Estado;

            personaDireccion.PersonaId = docente.PersonaId;
            personaDireccion.Direccion = docenteVM.HistoricoPersonaDireccion.Direccion;
            personaDireccion.Estado = docenteVM.HistoricoPersonaDireccion.Estado;

            dBRepository.Add(docente);
            dBRepository.Add(historicoDocumento);
            dBRepository.Add(historicoTelefono);
            dBRepository.Add(personaDireccion);
            dBRepository.Commit();

        }
        public DocenteVM Edit(int? Id, DocenteVM docenteVM)
        {
            var docentes = dBRepository.GetAll<Docente>();
            var Documentos = dBRepository.GetAll<HistoricoDocumentoPersona>();
            var telefonos = dBRepository.GetAll<HistoricoTelefonoPersona>();
            var Direccion = dBRepository.GetAll<HistoricoPersonaDireccion>();
            var especialidades = dBRepository.GetAll<Especialidad>();

            var person = from p in docentes
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
                             EspecialidadId=p.EspecialidadId,
                             historicoDocumentoid = d.HistoricoDocumentoPersonaId,
                             TipoDocumento = d.TipoDocumento,
                             Numero = d.Numero,
                             FechaExpedicion = d.FechaExpedicion,
                             estado = d.Estado,
                             historicoTelefonoid = tel.HistoricoTelefonoPersonaId,
                             TiposTelefono = tel.TiposTelefono,
                             numero = tel.Numero,
                             historicodireccionid = dir.HistoricoPersonaDireccionId,
                             Direccion = dir.Direccion
                         };

            var query = person.FirstOrDefault(x => x.PersonaId == Id);


            docente.PersonaId = query.PersonaId;
            docente.Nombres = query.Nombres;
            docente.ApellidoP = query.ApellidoP;
            docente.ApellidoM = query.ApellidoM;
            docente.FechaNacimiento = query.FechaNacimiento;
            docente.Genero = query.Genero;
            docente.RH = query.RH;
            docente.TipoSangre = query.TipoSangre;
            docente.Estado = query.Estado;

            docente.EspecialidadId = query.EspecialidadId;


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


            docenteVM.Docente = docente;
            docenteVM.HistoricoDocumentoPersona = historicoDocumento;
            docenteVM.HistoricoTelefonoPersona = historicoTelefono;
            docenteVM.HistoricoPersonaDireccion = personaDireccion;



            return docenteVM;
        }

        public void Updatedocente(DocenteVM docenteVM, int id)
        {
            docente.PersonaId = id;
            docente.Nombres = docenteVM.Docente.Nombres;
            docente.ApellidoP = docenteVM.Docente.ApellidoP;
            docente.ApellidoM = docenteVM.Docente.ApellidoM;
            docente.FechaNacimiento = docenteVM.Docente.FechaNacimiento;
            docente.Genero = docenteVM.Docente.Genero;
            docente.RH = docenteVM.Docente.RH;
            docente.TipoSangre = docenteVM.Docente.TipoSangre;
            docente.Estado = docenteVM.Docente.Estado;

            docente.EspecialidadId = docenteVM.Docente.EspecialidadId;

            historicoDocumento.PersonaId = docente.PersonaId;
            historicoDocumento.HistoricoDocumentoPersonaId = docenteVM.HistoricoDocumentoPersona.HistoricoDocumentoPersonaId;
            historicoDocumento.TipoDocumento = docenteVM.HistoricoDocumentoPersona.TipoDocumento;
            historicoDocumento.FechaExpedicion = docenteVM.HistoricoDocumentoPersona.FechaExpedicion;
            historicoDocumento.Numero = docenteVM.HistoricoDocumentoPersona.Numero;
            historicoDocumento.Estado = docenteVM.HistoricoDocumentoPersona.Estado;

            historicoTelefono.PersonaId = docente.PersonaId;
            historicoTelefono.HistoricoTelefonoPersonaId = docenteVM.HistoricoTelefonoPersona.HistoricoTelefonoPersonaId;
            historicoTelefono.TiposTelefono = docenteVM.HistoricoTelefonoPersona.TiposTelefono;
            historicoTelefono.Numero = docenteVM.HistoricoTelefonoPersona.Numero;
            historicoTelefono.Estado = docenteVM.HistoricoTelefonoPersona.Estado;

            personaDireccion.PersonaId = docente.PersonaId;
            personaDireccion.HistoricoPersonaDireccionId = docenteVM.HistoricoPersonaDireccion.HistoricoPersonaDireccionId;
            personaDireccion.Direccion = docenteVM.HistoricoPersonaDireccion.Direccion;
            personaDireccion.Estado = docenteVM.HistoricoPersonaDireccion.Estado;

            dBRepository.Update(docente);
            dBRepository.Update(historicoDocumento);
            dBRepository.Update(historicoTelefono);
            dBRepository.Update(personaDireccion);
            dBRepository.Commit();

        }

    }






}