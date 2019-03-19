using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RentaCars.EN;
using RentaCars.BL;

namespace RentaCarsWEB.Controllers
{
    public class EstadoController : Controller
    {
        private EstadoBL BL = new EstadoBL();
        // GET: Estado
        public ActionResult Index()
        {
            return View(BL.StateList());
        }

        // GET: Estado/Details/5
        public ActionResult Details(int id)
        {
            return View(BL.FindState(id));
        }

        // GET: Estado/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Estado/Create
        [HttpPost]
        public ActionResult Create(Estado esta)
        {
            try
            {
                // TODO: Add insert logic here
                if (esta != null)
                {
                    BL.AddEstado(esta);
                }
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        // GET: Estado/Edit/5
        public ActionResult Edit(int id)
        {
            return View(BL.FindState(id));
        }

        // POST: Estado/Edit/5
        [HttpPost]
        public ActionResult Edit(Estado st)
        {
            try
            {
                // TODO: Add update logic here
                BL.UpdateState(st);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Estado/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Estado/Delete/5
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
