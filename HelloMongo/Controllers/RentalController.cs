using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloMongo.Controllers
{
    public class RentalController : Controller
    {
        public MongoDBContext Context = new MongoDBContext();

        // GET: Rental
        public ActionResult Index()
        {
            var rentalDocs = Context.Rentals.FindAll();
            return View(rentalDocs);
        }

        // GET: Rental/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Rental/Create
        public ActionResult Create()
        {            
            return View();
        }

        // POST: Rental/Create
        [HttpPost]
        public ActionResult Create(Rental.Rental rental)
        {
            try
            {
                Context.Rentals.Insert(rental);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Rental/Edit/5
        public ActionResult Edit(string RentalId)
        {
            Rental.Rental myRental = Context.Rentals.FindOneById(new ObjectId(RentalId));
            return View(myRental);
        }

        // POST: Rental/Edit/5
        [HttpPost]
        public ActionResult Edit(Rental.Rental rental)
        {
            try
            {                
                Context.Rentals.Save(rental);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Rental/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Rental/Delete/5
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
