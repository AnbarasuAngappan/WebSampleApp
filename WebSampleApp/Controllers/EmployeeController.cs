using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSampleApp.Models;

namespace WebSampleApp.Controllers
{
    public class EmployeeController : Controller
    {      
        public ActionResult Details(string ID)
        {
            EmployeeContext employeeContext = new EmployeeContext();
            Employee employee = employeeContext.dbSetemployee.Single(Emp => Emp.EmployeeID == ID);
            return View(employee);
        }

        public ActionResult HyperDetails()
        {
            EmployeeContext employeecontext = new EmployeeContext();
            IList<Employee> employee = employeecontext.dbSetemployee.ToList();
            return View(employee);
        }
    }
}