using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CohortMidterm.Models;
using CohortMidterm.ViewModels;
using MidTerm.Models;

namespace CohortMidterm.Controllers
{
    public class StudentsController : Controller
    {
        private StudentAppContext db = new StudentAppContext();

        // GET: Students
        public ActionResult Index()
        {
            return View(db.Students.ToList());
        }

        // GET: Students/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Students students = db.Students.Find(id);
            if (students == null)
            {
                return HttpNotFound();
            }
            return View(students);
        }

        // GET: Students/Create
        public ActionResult Create()
        {           
            var student = new StudentViewModel()
            {
                Student = new Students(),
                CourseList = db.Courses.ToList(),
            };   
            
            return View(student);
        }

        // POST: Students/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(StudentViewModel students)
        {
            if (ModelState.IsValid)
            {
                db.Students.Add(students.Student);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            students.CourseList = db.Courses.ToList();

            return View(students);
        }

        // GET: Students/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var enrolled = new StudentViewModel()
            {
                Student = db.Students.Find(id),
                CourseList = db.Courses.ToList()
            };
            if (enrolled == null)
            {
                return HttpNotFound();
            }
            return View(enrolled);
        }

        // POST: Students/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(StudentViewModel students) 
        {
            if (ModelState.IsValid)
            {
                db.Entry(students.Student).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            students.CourseList = db.Courses.ToList();
            return View(students);
        }

        // GET: Students/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Students students = db.Students.Find(id);
            if (students == null)
            {
                return HttpNotFound();
            }
            return View(students);
        }

        // POST: Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Students students = db.Students.Find(id);
            db.Students.Remove(students);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
