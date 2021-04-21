using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vamos_Brincar.Models;

namespace Vamos_Brincar.Controllers
{
    public class CriancaController : Controller
    {
        // GET: Crianca
        CrudCrianca cc = new CrudCrianca();
        public ActionResult Index()
        {
            ModelState.Clear();
            return View(cc.GetCri());
        }

        // GET: Crianca/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Crianca/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Crianca/Create
        [HttpPost]
        public ActionResult Create(Criancamod criInsert)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    if (cc.insertCri(criInsert))
                    {
                        ViewBag.message = "Record saved Successfully";
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

        // GET: Crianca/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Crianca/Edit/5
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

        // GET: Crianca/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Crianca/Delete/5
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
