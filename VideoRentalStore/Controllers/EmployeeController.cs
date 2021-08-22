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
        db_VideoRentalstoreEntities dbObj = new db_VideoRentalstoreEntities(); //this is database object
        public ActionResult Employee()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddEmployee(tbl_employee model)
        {

            if(ModelState.IsValid){
                tbl_employee obj = new tbl_employee(); //tbl_employee is a table name
                obj.Name = model.Name;
                obj.Fname = model.Fname;
                obj.Email = model.Email;
                obj.Mobile = model.Mobile;
                obj.Description = model.Description;

                dbObj.tbl_employee.Add(obj);
                dbObj.SaveChanges();
            }
            ModelState.Clear();
        
            return View("Employee");
        }

        public ActionResult EmployeeList()
        {
            var res = dbObj.tbl_employee.ToList(); //dbObj is data object 
                return View(res);
        }

    }
}