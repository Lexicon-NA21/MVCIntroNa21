using Microsoft.AspNetCore.Mvc;
using MVCIntroNa21.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCIntroNa21.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index(string name, int salary)
        {
            //ViewData["name"] = name;
            //ViewData["salary"] = salary;

            //ViewBag.Name = name;
            //ViewBag.Salary = salary;
            var model = new Employee
            {
                Name = name,
                Salary = salary
            };

            return View(model);
        }
    }
}
