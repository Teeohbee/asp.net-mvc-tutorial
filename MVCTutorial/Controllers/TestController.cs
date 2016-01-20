using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCTutorial.Models;
using MVCTutorial.ViewModels;

namespace MVCTutorial.Controllers
{
    public class TestController : Controller
    {
        public ActionResult GetView()
        {
            Employee emp = new Employee
            {
                FirstName = "Toby",
                LastName = "Clarke",
                Salary = 99999
            };

            EmployeeViewModel vmEmp = new EmployeeViewModel
            {
                EmployeeName = emp.FirstName + " " + emp.LastName,
                Salary = emp.Salary.ToString("C"),
                UserName = "Admin",
                SalaryColor = emp.Salary > 15000 ? "yellow" : "green"
            };

            return View("MyView", vmEmp);
        }
        public string GetString()
        {
            return "Hello World";
        }
    }
}