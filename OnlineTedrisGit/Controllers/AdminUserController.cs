using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineTedris.Models.DbModels;
using OnlineTedris.Context;

namespace OnlineTedris.Controllers
{
    public class AdminUserController : Controller
    {
        // GET: AdminUser
        DbTraining db = new DbTraining();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult LoginAdmin(AdminUser adminUser)
        {
            if (!ModelState.IsValid)
            {
                return View("Index");
            }
            var istifadeci = db.AdminUsers.FirstOrDefault(x => x.Username == adminUser.Username && x.Passvords == adminUser.Passvords);
            if (istifadeci!=null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.message = "Istifadəçi adı və ya şifrə yalnışdır!";
                return View();
            }
            
        }
    }
}