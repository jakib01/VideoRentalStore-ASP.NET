using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VideoRentalStore.Models;

namespace VideoRentalStore.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie()
            {
                Id = 1,
                Name = "movie name"
            };

            return View(movie);
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }
    }
}