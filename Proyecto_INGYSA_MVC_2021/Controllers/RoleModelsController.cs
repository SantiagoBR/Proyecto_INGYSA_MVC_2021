using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Proyecto_INGYSA_MVC_2021.Models;

namespace Proyecto_INGYSA_MVC_2021.Controllers
{
    public class RoleModelsController : Controller
    {
        private INGYSA_DB_Context db = new INGYSA_DB_Context();

        // GET: RoleModels
        public ActionResult Index()
        {
            return View(db.RoleModel.ToList());
        }

        // GET: RoleModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RoleModel roleModel = db.RoleModel.Find(id);
            if (roleModel == null)
            {
                return HttpNotFound();
            }
            return View(roleModel);
        }

        // GET: RoleModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RoleModels/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RoleID,Role")] RoleModel roleModel)
        {
            if (ModelState.IsValid)
            {
                db.RoleModel.Add(roleModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(roleModel);
        }

        // GET: RoleModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RoleModel roleModel = db.RoleModel.Find(id);
            if (roleModel == null)
            {
                return HttpNotFound();
            }
            return View(roleModel);
        }

        // POST: RoleModels/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RoleID,Role")] RoleModel roleModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(roleModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(roleModel);
        }

        // GET: RoleModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RoleModel roleModel = db.RoleModel.Find(id);
            if (roleModel == null)
            {
                return HttpNotFound();
            }
            return View(roleModel);
        }

        // POST: RoleModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RoleModel roleModel = db.RoleModel.Find(id);
            db.RoleModel.Remove(roleModel);
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
