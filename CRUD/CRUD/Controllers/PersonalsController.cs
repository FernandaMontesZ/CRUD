﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using CRUD.Models;

namespace CRUD.Controllers
{
    public class PersonalsController : Controller
    {
        private EmpleadosEntities db = new EmpleadosEntities();
        private EmpleadosBD emDB = new EmpleadosBD();

        // GET: Personals
        public ActionResult Index()
        {
            return View(db.Personal.ToList());
        }
<<<<<<< HEAD
        //GET: envia lista de todo el personal
        public JsonResult ReadListaPersonal()
        {
            var result = emDB.RealAll();
            return Json(result, JsonRequestBehavior.AllowGet);
        }
=======
>>>>>>> c995b5ecb23af276594ba59da7e08628b4c0d910

        // GET: Personals/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Personals/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Personal personal)
        {
<<<<<<< HEAD
            if (db.Personal != null)
            {
                db.Personal.Add(personal);
                db.SaveChanges();
            }

            return View("Index");
        }

        //Obtiene empleado por id 
        public JsonResult GetbyID(int ID_personal)

        {
            var Empleado = emDB.RealAll().Find(x => x.ID_personal.Equals(ID_personal));

            return Json(Empleado, JsonRequestBehavior.AllowGet);

        }

        public ActionResult UpdateAjax(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Personal personal = db.Personal.Find(id);
            if (personal == null)
            {
                return HttpNotFound();
            }
            //return View(personal);
            return Json(emDB.Update(personal), JsonRequestBehavior.AllowGet);
        }
        public JsonResult DeleteAjax(int ID_personal)
        {
            return Json(emDB.Delete(ID_personal), JsonRequestBehavior.AllowGet);
        }
        //lista de personal
        //public JsonResult getNewPersonal ()
        //{
        //    List<Personal> lsPers = new List<Personal>();
        //    lsPers=db.Personal.ToList();
        //    return Json(lsPers, JsonRequestBehavior.AllowGet);
        //}
=======
            Thread.Sleep(5000);
            bool res = false;
            string mensaje = "Error al ingresar el registro del personal";
            var lsPersonal = db.Personal.ToList();
            if (lsPersonal != null)
            {
                db.Personal.Add(personal);
                db.SaveChanges();
                res = true;
                mensaje = "Personal agregado";
            }
            return Json(new { res = res, mensaje = mensaje}, JsonRequestBehavior.AllowGet);
        }

        // GET: Personals/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Personal personal = db.Personal.Find(id);
            if (personal == null)
            {
                return HttpNotFound();
            }
            return View(personal);
        }

        
>>>>>>> c995b5ecb23af276594ba59da7e08628b4c0d910

        // GET: Personals/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Personal personal = db.Personal.Find(id);
            if (personal == null)
            {
                return HttpNotFound();
            }
            return View(personal);
        }

        // POST: Personals/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_personal,Nombre,ApePaterno,ApeMaterno,Edad,IsActive")] Personal personal)
        {
            if (ModelState.IsValid)
            {
                db.Entry(personal).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(personal);
        }

        // GET: Personals/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Personal personal = db.Personal.Find(id);
            if (personal == null)
            {
                return HttpNotFound();
            }
            return View(personal);
        }

        // POST: Personals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Personal personal = db.Personal.Find(id);
            db.Personal.Remove(personal);
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

        // GET: Personals/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Personal personal = db.Personal.Find(id);
            if (personal == null)
            {
                return HttpNotFound();
            }
            return View(personal);
        }
    }
}
