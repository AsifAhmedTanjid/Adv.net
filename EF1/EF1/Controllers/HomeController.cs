using EF1.EF;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EF1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Department()
        {
            var db = new SunniestWigEntities();
            var data = db.Departments.ToList();

            return View(data);
        }



        public ActionResult Student()
        {
            var db = new SunniestWigEntities();
            var data = db.Students.ToList();

            return View(data);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Department d) {
            
            var db = new SunniestWigEntities();
            db.Departments.Add(d);
            db.SaveChanges();
            return RedirectToAction("Department");


        }


        [HttpGet]
        public ActionResult CreateStudent()
        {
            var db = new SunniestWigEntities();
            ViewBag.Departments = db.Departments.ToList();
            return View();
        }
        [HttpPost]
        public ActionResult CreateStudent(Student s)
        {

            var db = new SunniestWigEntities();
            db.Students.Add(s);
            db.SaveChanges();
            return RedirectToAction("Student");


        }

       
       

        [HttpGet]
        public ActionResult EditStudent(int id)
        {
            var db = new SunniestWigEntities();
            var data = (from s in db.Students
                        where s.Id == id
                        select s).SingleOrDefault();
            return View(data);
        }

        [HttpPost]
        public ActionResult EditStudent(Student s)
        {
            var db = new SunniestWigEntities();
            var data = db.Students.Find(s.Id);
            data.Name = s.Name;
            data.CGPA = s.CGPA;
            db.SaveChanges();


            return RedirectToAction("Student");
            
        }

        public ActionResult DeleteStudent(int id)
        {
            var db = new SunniestWigEntities();
            var data = (from s in db.Students
                        where s.Id == id
                        select s).SingleOrDefault();
            return View(data);
        }

        [HttpPost]
        public ActionResult ConfirmDeleteStudent(int id)
        {
            var db = new SunniestWigEntities();
            var data = (from s in db.Students
                        where s.Id == id
                        select s).SingleOrDefault();
            db.Students.Remove(data);
            db.SaveChanges();
            return RedirectToAction("Student");
        }



    }
}