using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReviewsSite.Models;
using ReviewsSite.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewsSite.Controllers
{
    public class HauntedHouseController : Controller
    {
        private IRepository<HauntedHouse> _HauntedHouseRepo;

        public HauntedHouseController(IRepository<HauntedHouse> HauntedHouseRepo)
        {
            this._HauntedHouseRepo = HauntedHouseRepo;
        }
        // GET: HauntedHouseController
        public ActionResult Index()
        {
            return View(_HauntedHouseRepo.GetAll());
        }

        // GET: HauntedHouseController/Details/5
        public ActionResult Details(int id)
        {
            return View(_HauntedHouseRepo.GetByID(id));
        }

        // GET: HauntedHouseController/Create
        public IActionResult AddHauntedHouse()
        {
            return View(new HauntedHouse());
        }


        [HttpPost]
        public IActionResult AddHauntedHouse(HauntedHouse newHauntedHouse)
        {
            _HauntedHouseRepo.Create(newHauntedHouse);
            //if (!String.IsNullOrEmpty(newHauntedHouse.Name))
            //{
            //    _HauntedHouseRepo.Create(newHauntedHouse);
            //    ViewBag.Result = "You have successfully added a haunted house!";
            //}
            //else
            //{
            //    ViewBag.Error = "Name is required, please try again.";
            //}

            return RedirectToAction("Index");
        }

        // POST: HauntedHouseController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: HauntedHouseController/Edit/5
        public IActionResult EditHauntedHouse(int id)
        {
             
            var hauntedhouse = _HauntedHouseRepo.GetByID(id);
            return View(hauntedhouse);
        }

        // POST: HauntedHouseController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditHauntedHouse(int id, HauntedHouse hauntedhouse)
        {
            //We need to reference the object of HauntedHouse to edit

            //_HauntedHouseRepo.Update(obj);
            //HauntedHouseRepo.SaveChanges();
            //var HauntedHouseToEdit = _HauntedHouseRepo.GetByID(id);
            _HauntedHouseRepo.Update(hauntedhouse);
            ViewBag.ReplyMessage = "You have successfully updated the Haunted House.";
            return View(new HauntedHouse());


            //try
            //{
            //    return RedirectToAction(nameof(Index));
            //}
            //catch
            //{
            //    return View();
            //}
        }

        // GET: HauntedHouseController/Delete/5
        public ActionResult DeleteHauntedHouse(int id)
        {
            var HauntedHouseToDelete = _HauntedHouseRepo.GetByID(id);
            _HauntedHouseRepo.Delete(HauntedHouseToDelete);
            return RedirectToAction("Index");
        }

        //// POST: HauntedHouseController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
