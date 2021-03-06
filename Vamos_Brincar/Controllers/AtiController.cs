using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vamos_Brincar.Models;

namespace Vamos_Brincar.Controllers
{
    public class AtiController : Controller
    {
        // GET: Ati
        CrudImplementation ci = new CrudImplementation();
        public ActionResult Index()
        {
            ModelState.Clear();
            return View(ci.GetAti());
        }

        // GET: Ati/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Ati/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ati/Create
        [HttpPost]
        public ActionResult Create(CrudProp atiInsert)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    if(ci.insertAti(atiInsert))
                    {
                        ViewBag.message = "Introduzido com sucesso! ";
                        ModelState.Clear();
                    }
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Ati/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Ati/Edit/5
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

        // GET: Ati/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Ati/Delete/5
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
