using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VideoRentalStore.Context;

namespace VideoRentalStore.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        db_VideoRentalstoreEntities dbObj = new db_VideoRentalstoreEntities();
        public ActionResult Employee()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddEmployee(tbl_employee model)
        {
            tbl_employee obj = new tbl_employee();
            return View();
        }
    }
}