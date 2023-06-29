using System;

using System.Web.Mvc;

namespace FormProgramming.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        [HttpGet]
        public ActionResult CreateEmployee()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateEmployee(string EmpCode,string EmpName,string EmpAge)
        {
            Response.Write("EmpCode: "+EmpCode+"   EmpName: "+EmpName+"   EmpAge: "+EmpAge);
            return View();
        }
    }
}