using DefectTrackerApp.DAL.Interface;
using DefectTrackerApp.DAL.Repository;
using DefectTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace DefectTrackerApp.Controllers
{
    public class DefectTrackerController : Controller
    {
        private readonly IDefectTrackerInterface _Repository;
        public DefectTrackerController(IDefectTrackerInterface service)
        {
            _Repository = service;
        }
        public DefectTrackerController()
        {
            // Constructor logic, if needed
        }
        // GET: DefectTracker
        public ActionResult Index()
        {
            var Defects = from work in _Repository.GetDefects()
                        select work;
            return View(Defects);
        }

        public ViewResult Details(int id)
        {
            Defect Defect =   _Repository.GetDefectByID(id);
            return View(Defect);
        }

        public ActionResult Create()
        {
            return View(new Defect());
        }

        [HttpPost]
        public ActionResult Create(Defect Defect)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _Repository.InsertDefect(Defect);
                    _Repository.Save();
                    return RedirectToAction("Index");
                }
            }
            catch (DataException)
            {
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }
            return View(Defect);
        }

        public ActionResult EditAsync(int id)
        {
            Defect Defect =  _Repository.GetDefectByID(id);
            return View(Defect);
        }
        [HttpPost]
        public ActionResult Edit(Defect Defect)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _Repository.UpdateDefect(Defect);
                    _Repository.Save();
                    return RedirectToAction("Index");
                }
            }
            catch (DataException)
            {
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }
            return View(Defect);
        }

        public ActionResult Delete(int id, bool? saveChangesError)
        {
            if (saveChangesError.GetValueOrDefault())
            {
                ViewBag.ErrorMessage = "Unable to save changes. Try again, and if the problem persists see your system administrator.";
            }
            Defect Defect =  _Repository.GetDefectByID(id);
            return View(Defect);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                Defect Defect =  _Repository.GetDefectByID(id);
                _Repository.DeleteDefect(id);
                _Repository.Save();
            }
            catch (DataException)
            {
                return RedirectToAction("Delete",
                   new System.Web.Routing.RouteValueDictionary {
        { "id", id },
        { "saveChangesError", true } });
            }
            return RedirectToAction("Index");
        }
    }
}