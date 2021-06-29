using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Proyecto_INGYSA_MVC_2021.Areas.PERSONAS.Data;
using Proyecto_INGYSA_MVC_2021.Areas.PERSONAS.Data.MVVM;
using Proyecto_INGYSA_MVC_2021.Areas.PERSONAS.Logica_Negocio;
using Proyecto_INGYSA_MVC_2021.Models;

namespace Proyecto_INGYSA_MVC_2021.Areas.PERSONAS.Controllers
{
    public class DocentesController : Controller
    {
        private INGYSA_DB_Context db = new INGYSA_DB_Context();

        private void listadeEspecialidad()
        {
            ViewBag.Especialidades = from e in db.Especialidad
                                     orderby e.Descripcion
                                     select e;
        }


        // GET: PERSONAS/Docentes
        public ActionResult Index(string filtro)
        {
            if (User.Identity.Name == "")
            {
                return RedirectToAction("Index", "Home", new { @area = "" });
            }
            DocenteVM docenteVM = new DocenteVM();
            if (String.IsNullOrEmpty(filtro))
            {
                docenteVM.docentes = db.Docentes.ToList();
                docenteVM.HistoricoDocumentoPersonas = db.HistoricoDocumentoPersonas.ToList();
                docenteVM.HistoricoTelefonoPersonas = db.HistoricoTelefonoPersonas.ToList();
                docenteVM.HistoricoPersonaDireccions = db.HistoricoPersonaDireccions.ToList();
            }
            else
            {
                docenteVM.HistoricoDocumentoPersonas = new List<HistoricoDocumentoPersona>();
                docenteVM.HistoricoTelefonoPersonas = new List<HistoricoTelefonoPersona>();
                docenteVM.HistoricoPersonaDireccions = new List<HistoricoPersonaDireccion>();
                docenteVM.docentes = db.Docentes.Where(s => s.ApellidoP.Contains(filtro.Trim())).ToList();
                for (int x = 0; x < docenteVM.docentes.Count; x++)
                {
                    int personaId = docenteVM.docentes[x].PersonaId;
                    docenteVM.HistoricoDocumentoPersonas.Add(db.HistoricoDocumentoPersonas.Where(s => s.PersonaId == personaId).FirstOrDefault());
                    docenteVM.HistoricoTelefonoPersonas.Add(db.HistoricoTelefonoPersonas.Where(s => s.PersonaId == personaId).FirstOrDefault());
                    docenteVM.HistoricoPersonaDireccions.Add(db.HistoricoPersonaDireccions.Where(s => s.PersonaId == personaId).FirstOrDefault());
                }
            }   
            return View(docenteVM);
        }

        // GET: PERSONAS/Docentes/Details/5
        public ActionResult Details(int? id)
        {
            if (User.Identity.Name == "")
            {
                return RedirectToAction("Index", "Home", new { @area = "" });
            }
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Persona persona = db.Personas.Find(id);
            if (persona == null)
            {
                return HttpNotFound();
            }
            return View(persona);
        }

        // GET: PERSONAS/Docentes/Create
        public ActionResult Create()
        {
            if (User.Identity.Name == "")
            {
                return RedirectToAction("Index", "Home", new { @area = "" });
            }
            listadeEspecialidad();
            return View();
        }

        // POST: PERSONAS/Docentes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DocenteVM docenteVM)
        {
            if (ModelState.IsValid)
            {
                Docente_Negocio BDocente = new Docente_Negocio();
                BDocente.CrearDocente(docenteVM);

                return RedirectToAction("Index");
            }

            return View(docenteVM);
        }

        // GET: PERSONAS/Docentes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (User.Identity.Name == "")
            {
                return RedirectToAction("Index", "Home", new { @area = "" });
            }
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DocenteVM docenteVM = new DocenteVM();
            Docente_Negocio BDocente = new Docente_Negocio();

            BDocente.Edit(id, docenteVM);
            listadeEspecialidad();

            if (docenteVM == null)
            {
                return HttpNotFound();
            }
            return View(docenteVM);
        }

        // POST: PERSONAS/Docentes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(DocenteVM docenteVM, int id)
        {
            if (ModelState.IsValid)
            {
                Docente_Negocio BDocente = new Docente_Negocio();
                BDocente.Updatedocente(docenteVM, id);

                return RedirectToAction("Index");
            }
            return View(docenteVM);
        }

        // GET: PERSONAS/Docentes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (User.Identity.Name == "")
            {
                return RedirectToAction("Index", "Home", new { @area = "" });
            }
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Persona persona = db.Personas.Find(id);
            if (persona == null)
            {
                return HttpNotFound();
            }
            return View(persona);
        }

        // POST: PERSONAS/Docentes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Persona persona = db.Personas.Find(id);
            db.Personas.Remove(persona);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
