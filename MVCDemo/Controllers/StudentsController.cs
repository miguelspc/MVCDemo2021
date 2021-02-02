using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models.Data;

namespace MVCDemo.Controllers
{
    public class StudentsController : Controller
    {
        // GET: StudentsController
        public ActionResult Index()
        {
            
            return View(Singleton.Instance.StudentsList);
        }

        // GET: StudentsController/Details/5
        public ActionResult Details(int id)
        {
            var ViewStudent = Singleton.Instance.StudentsList.Find(x => x.Id == id);
            return View(ViewStudent);
        }

        // GET: StudentsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                var newStudent = new Models.Student { 
                    Id = Convert.ToInt32(collection["Id"]),
                    Name = collection["Name"],
                    BirthDate  = Convert.ToDateTime(collection["BirthDate"])
                };
                Singleton.Instance.StudentsList.Add(newStudent);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentsController/Edit/5
        public ActionResult Edit(int id)
        {
            var editStudent = Singleton.Instance.StudentsList.Find(x => x.Id == id);
            return View(editStudent);
        }

        // POST: StudentsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StudentsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
