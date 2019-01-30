using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineTedris.Context;
using OnlineTedris.Models.DbModels;

namespace OnlineTedris.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        DbTraining dbTraining = new DbTraining();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken] //Link ile gelende emeliyyet yerine yetirmir həm dizaynda hem burda yazilmalidir.
        public ActionResult RegisterStudent(Telebe telebe)
        {
            if(!ModelState.IsValid)
            {
                return View("Index");
            }
            if(telebe.ID==0)
            {
                dbTraining.Telebes.Add(telebe);
            }
            dbTraining.SaveChanges();
            return RedirectToAction("Index"); 
        }
    }
}