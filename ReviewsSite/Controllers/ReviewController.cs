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
            return RedirectToAction("Index");
        }
    }
}
