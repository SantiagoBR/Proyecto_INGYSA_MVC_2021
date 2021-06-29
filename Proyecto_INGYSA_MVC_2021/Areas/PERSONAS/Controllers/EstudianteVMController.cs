using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Proyecto_INGYSA_MVC_2021.Areas.PERSONAS.Data;
using Proyecto_INGYSA_MVC_2021.Areas.PERSONAS.Data.MVVM;
using Proyecto_INGYSA_MVC_2021.Areas.PERSONAS.Logica_Negocio;
using Proyecto_INGYSA_MVC_2021.Models;

namespace Proyecto_INGYSA_MVC_2021.Areas.PERSONAS.Controllers
{
    public class EstudianteVMController : Controller
    {
        private INGYSA_DB_Context db = new INGYSA_DB_Context();

        // GET: PERSONAS/EstudianteVM
        public ActionResult Index()
        {
            if (User.Identity.Name == "")
            {
                return RedirectToAction("Index", "Home", new { @area = "" });
            }
            EstudianteVM estudianteVM = new EstudianteVM();
            estudianteVM.estudiantes = db.Estudiantes.ToList(); 
            estudianteVM.HistoricoDocumentoPersonas = db.HistoricoDocumentoPersonas.ToList();
            estudianteVM.HistoricoTelefonoPersonas = db.HistoricoTelefonoPersonas.ToList();
            estudianteVM.HistoricoPersonaDireccions = db.HistoricoPersonaDireccions.ToList();

            return View(estudianteVM);
        }

        // GET: PERSONAS/EstudianteVM/Details/5
        public ActionResult Details(int? id)
        {
            if (User.Identity.Name == "")
            {
                return RedirectToAction("Index", "Home", new { @area = ""});
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

        // GET: PERSONAS/EstudianteVM/Create
        public ActionResult Create()
        {
            if (User.Identity.Name == "")
            {
                return RedirectToAction("Index", "Home", new { @area = "" });
            }
            return View();
        }

        // POST: PERSONAS/EstudianteVM/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EstudianteVM estudianteVM)
        {
            if (ModelState.IsValid)
            {
                Estudiante_Negocio Bestudiante = new Estudiante_Negocio();
                Bestudiante.CrearEstudiante(estudianteVM);

                return RedirectToAction("Index");
            }

            return View(estudianteVM);
        }

        // GET: PERSONAS/EstudianteVM/Edit/5
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
            EstudianteVM estudianteVM = new EstudianteVM();
            Estudiante_Negocio Bestudiante = new Estudiante_Negocio();

            Bestudiante.Edit(id, estudianteVM);

            if (estudianteVM == null)
            {
                return HttpNotFound();
            }
            return View(estudianteVM);
        }

        // POST: PERSONAS/EstudianteVM/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EstudianteVM estudianteVM, int id)
        {
            if (ModelState.IsValid)
            {
                Estudiante_Negocio Bestudiane = new Estudiante_Negocio();
                Bestudiane.UpdateEstudiante(estudianteVM, id);

                return RedirectToAction("Index");
            }
            return View(estudianteVM);
        }

        // GET: PERSONAS/EstudianteVM/Delete/5
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

        // POST: PERSONAS/EstudianteVM/Delete/5
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
