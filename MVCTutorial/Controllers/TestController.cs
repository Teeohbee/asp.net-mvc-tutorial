using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCTutorial.Models;

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
            return View("MyView", emp);
        }
        public string GetString()
        {
            return "Hello World";
        }
    }
}