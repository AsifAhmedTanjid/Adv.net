using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _1STDAY.Controllers
{
    public class ProfileController : Controller
    {
        //public string name = "asif ahmed tanjid";
        public ActionResult Index()
        {
            ViewBag.Name = "Asif Ahmed Tanjid";
            ViewBag.ID = "20-44249-3";
            ViewBag.Inst = " AIUB";
            ViewBag.CGPA = 3.98;


            return View();
        }

        public ActionResult Bio()
        {
            ViewBag.Name = "Asif Ahmed Tanjid";
            ViewBag.ID = "20-44249-3";
            ViewBag.Inst = " AIUB";
            ViewBag.CGPA = 3.98;
            ViewBag.Subject = " BSc in CSE";
            return View();
        }
    }

    
}