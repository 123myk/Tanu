using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormProgramming.Controllers
{
    public class Employee1Controller : Controller
    {
        // GET: Employee1
        [HttpGet]
        public ActionResult CreateEmployee()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateEmployee(FormCollection forms)
        {
            string id = forms["EmpCode"];
            string name = forms["EmpName"];
            string age = forms["EmpAge"];
            Response.Write("EmpCode: " + id + "   EmpName: " + name + "   EmpAge: " + age);
            return View();
        }
    }
}