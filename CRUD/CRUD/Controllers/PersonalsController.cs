using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUD.Controllers
{
    public class PersonalsController : Controller
    {
        // GET: Personals
        public ActionResult Index()
        {
            return View();
        }

        // GET: Personals/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Personals/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Personals/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Personals/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Personals/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Personals/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Personals/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
