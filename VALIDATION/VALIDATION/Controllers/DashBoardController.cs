using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VALIDATION.Controllers
{
    public class DashBoardController : Controller
    {
        // GET: DashBoard
        public ActionResult Profiles()
        {
            return View();
        }
        public ActionResult Education()
        {
            return View();
        }
        public ActionResult Logout()
        {
            return View();
        }
    }
}