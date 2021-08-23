using System;
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
            
            if (ModelState.IsValid)
            {
                tbl_employee obj = new tbl_employee(); //tbl_employee is a table name
                obj.Name = model.Name;
                obj.Fname = model.Fname;
                obj.Email = model.Email;
                obj.Mobile = model.Mobile;
                obj.Description = model.Description;

                dbObj.tbl_employee.Add(obj);
                dbObj.SaveChanges();
                ModelState.Clear();

            }
            var errors = ModelState.Values.SelectMany(v => v.Errors);

            return View("Employee");
            //return Content("<script> alert('hello" + errors + "hello') </script>");
        }

        public ActionResult EmployeeList()
        {
            var res = dbObj.tbl_employee.ToList(); //dbObj is data object 
            return View(res);
        }

        public ActionResult EmployeeDelete(int id)
        {
            var res = dbObj.tbl_employee.Where(x => x.ID == id).First();
            dbObj.tbl_employee.Remove(res);
            dbObj.SaveChanges();
            var list = dbObj.tbl_employee.ToList();
            return View("EmployeeList", list);
        }  

        public ActionResult EmployeeEdit(int id)
        {
            var employeeData = dbObj.tbl_employee.Where(x => x.ID == id).First();
            return View("EmployeeEdit",employeeData);
        }


        public ActionResult EmployeeEditStore(tbl_employee model)
        {

            if (ModelState.IsValid)
            {
                var employeeData = dbObj.tbl_employee.Where(x => x.ID == model.ID).FirstOrDefault();
                employeeData.Name = model.Name;
                employeeData.Fname = model.Fname;
                employeeData.Email = model.Email;
                employeeData.Mobile = model.Mobile;
                employeeData.Description = model.Description;

                dbObj.Entry(employeeData).State = System.Data.Entity.EntityState.Modified;
                dbObj.SaveChanges();
                //ModelState.Clear();
            }

            var list = dbObj.tbl_employee.ToList();
            return View("EmployeeList", list);
        }

    }
}