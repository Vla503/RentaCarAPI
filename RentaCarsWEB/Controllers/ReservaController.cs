using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RentaCars.EN;
using RentaCars.BL;

namespace RentaCarsWEB.Controllers
{
   
    public class ReservaController : Controller
    {
        private ReservaBL BL = new ReservaBL();
        private VehiculoBL VBL = new VehiculoBL();
        // GET: Reserva
        public ActionResult Index(string state)
        {
            return View(BL.ReservaList(state));
        }

        // GET: Reserva/Details/5
        public ActionResult Details(int id)
        {
            return View(BL.FindReserva(id));
        }

        // GET: Reserva/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Reserva/Create
        [HttpPost]
        public ActionResult Create(Reserva re)
        {
            try
            {
                // TODO: Add insert logic here
                if (re != null)
                {
                    BL.AddReserva(re);
                }
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        // GET: Reserva/Edit/5
        public ActionResult Edit(int id)
        {
            return View(BL.FindReserva(id));
        }

        // POST: Reserva/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Reserva re)
        {
            try
            {
                // TODO: Add update logic here
                BL.UpdateReserva(re);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Reserva/Delete/5
        public ActionResult Delete(int id)
        {
            return View(BL.FindReserva(id));
        }

        // POST: Reserva/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                BL.DeleteReserva(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Usuario(string state)
        {
            try
            {
                return View(VBL.VehiculoList(state));
            }
            catch
            {
                return View();
            }
        }
    }
}
