using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestProject_gridview.Models;

namespace TestProject_gridview.Controllers
{
    public class TestGridController : Controller
    {
        EmployeeDbContext db = new EmployeeDbContext();
        // GET: TestGrid
        public ActionResult Index()
        {
            var EmployeeList = db.Employee.Where(x=>x.IsActive==false).ToList();
            return View(EmployeeList);
        }
        //post method
        [HttpPost]
        public ActionResult Index(Employee emp)
        {
            return View();
        }

        public ActionResult DeleteAction(int id)
        {
            var employee = db.Employee.Where(x => x.Id == id).FirstOrDefault();

            employee.IsActive = true;

            db.Entry(employee).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

            ViewBag.Message = "Deleted";
            return RedirectToAction("Index");
        }

    }
}