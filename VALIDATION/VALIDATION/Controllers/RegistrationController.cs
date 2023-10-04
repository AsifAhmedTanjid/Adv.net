using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VALIDATION.Models;

namespace VALIDATION.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult Home()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginModel login)
        {
            return View(login);
        }
        [HttpGet]
        public ActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(SignUpModel signup)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Profiles","DashBoard");
            }
            return View(signup);
        }
    }
}