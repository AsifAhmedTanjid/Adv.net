using EF1.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EF1.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult Index()
        {
            var db = new SunniestWigEntities();
            var data = db.Courses.ToList();
            return View(data);

        }

        [HttpPost]
        public ActionResult Register(int SId, int[] Courses)
        {
            var db = new SunniestWigEntities();
            foreach (var c in Courses)
            {
                var cs = new CourseStudent()
                {
                    Sid = SId,
                    Cid = c,
                    EnrollTime = DateTime.Now
                };
                db.CourseStudents.Add(cs);
            }

            db.SaveChanges();
            return RedirectToAction("Index");
        }
      
        public ActionResult Drop()
        {
            var db = new SunniestWigEntities();
            var data = db.CourseStudents.ToList();
            return View(data);

        }
       
        public ActionResult Dropcourse(int id)
        {
            var db = new SunniestWigEntities();
            var data = (from cs in db.CourseStudents
                        where cs.Id == id
                        select cs).SingleOrDefault();
            db.CourseStudents.Remove(data);
            db.SaveChanges();
            return RedirectToAction("Drop");

        }
    }
}