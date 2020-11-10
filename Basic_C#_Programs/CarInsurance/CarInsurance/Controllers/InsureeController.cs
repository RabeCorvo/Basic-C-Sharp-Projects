using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
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

        //private int CalculateAge(int Id)
        //{
        //    using (InsuranceEntities db = new InsuranceEntities())
        //    {
        //        int age = 0;
        //        var insuree = db.Insurees.Find(Id);
        //        age = DateTime.Now.Year - insuree.DateOfBirth.Year;
        //        if (DateTime.Now.DayOfYear < insuree.DateOfBirth.DayOfYear)
        //        {
        //            age -= 1;
        //        }
        //        return age;
        //    }
        //}

        public ActionResult GenerateQuote(int Id)
        {
            decimal quote = 50.00m;
            using (InsuranceEntities db = new InsuranceEntities())
            {
                var client = db.Insurees.Find(Id);
                //int age = CalculateAge(Id);
                var insuree = db.Insurees.Find(Id);
                int age = DateTime.Now.Year - insuree.DateOfBirth.Year;
                if (DateTime.Now.DayOfYear < insuree.DateOfBirth.DayOfYear)
                {
                    age -= 1;
                }
                if (age <= 18)
                {
                    quote += 100m;
                }
                else if (age > 18 && age < 26)
                {
                    quote += 50m;
                }
                else
                {
                    quote += 25m;
                }
                if (client.CarYear < 2000 || client.CarYear > 2015)
                {
                    quote += 25m;
                }
                if (client.CarMake == "Porsche")
                {
                    quote += 25m;
                }
                if (client.CarMake == "Porsche" && client.CarModel == "911 Carrera")
                {
                    quote += 25m;
                }
                if (client.SpeedingTickets > 0)
                {
                    int ticketMultiplyer = client.SpeedingTickets * 10;
                    quote = quote + ticketMultiplyer;
                }
                if (client.DUI == true)
                {
                    quote *= 1.25m;
                }
                if (client.CoverageType == true)
                {
                    quote *= 1.5m;
                }
                client.Quote = quote;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }


    }
}
