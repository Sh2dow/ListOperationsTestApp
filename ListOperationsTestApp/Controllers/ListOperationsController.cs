using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ListOperationsTestApp.Controllers
{
    public class ListOperationsController : Controller
    {
        // GET: ListOperations
        public ActionResult Index()
        {
            return View();
        }

        // GET: ListOperations/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ListOperations/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ListOperations/Create
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

        // GET: ListOperations/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ListOperations/Edit/5
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

        // GET: ListOperations/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ListOperations/Delete/5
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
