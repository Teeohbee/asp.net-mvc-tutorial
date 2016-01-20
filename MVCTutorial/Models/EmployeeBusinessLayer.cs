using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTutorial.Models
{
    public class EmployeeBusinessLayer
    {
        public List<Employee> GetEmployees()
        {
            List < Employee > employees = new List<Employee>();

            for (int i = 0; i < 5; i++)
            {
                Employee emp = new Employee
                {
                    FirstName = "johnson",
                    LastName = " fernandes",
                    Salary = 14000
                };
                employees.Add(emp);
            }
            return employees;
        } 
    }
}