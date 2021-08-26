using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VideoRentalStore.Context;

namespace VideoRentalStore.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        db_VideoRentalstoreEntities dbObj = new db_VideoRentalstoreEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetData()
        {
            var res = dbObj.tbl_users.ToList(); //dbObj is data object 
            return Json(new { data = res}, JsonRequestBehavior.AllowGet);
        }
    }
}