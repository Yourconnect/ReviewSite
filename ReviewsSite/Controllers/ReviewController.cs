using Microsoft.AspNetCore.Mvc;
using ReviewsSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Controllers
{
    public class ReviewController : Controller
    {
        private HauntedHousesContext _db;
        public ReviewController(HauntedHousesContext db)
        {
            this._db = db;
        }
        public IActionResult Index()
        {
            return View(_db.Reviews.ToList());
        }

        //reminder: remove the create new review from review index
        public IActionResult Create(int id)
        {
            ViewBag.HauntedHouseId = id;
            return View();
        }
        [HttpPost]
        public IActionResult Create(Review review )
        {
            review.Id = 0;
            _db.Reviews.Add(review);
            _db.SaveChanges();
            return RedirectToAction("Details", "HauntedHouse", new { id = review.HauntedHouseId });
        }
        public IActionResult EditReview(int id)
        {
           
            return View(_db.Reviews.Find(id));
        }

        // POST: HauntedHouseController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditReview(int id, Review obj)
        {

            _db.Reviews.Update(obj);
            _db.SaveChanges();
            return RedirectToAction("Details", "HauntedHouse", new { id = obj.HauntedHouseId });

        }
        public ActionResult DeleteReview(int id)
        {
            var ReviewToDelete = _db.Reviews.Find(id);
            _db.Reviews.Remove(ReviewToDelete);
            _db.SaveChanges();
            return RedirectToAction("Details", "HauntedHouse", new { id = ReviewToDelete.HauntedHouseId });
        }
    }
}
