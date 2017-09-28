using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller //When running the path of the URL accesses a controller first and then the action that is requested
                                                   //This is known as URL routing
    {
        public ActionResult Detail()
        {
            if(DateTime.Today.DayOfWeek == DayOfWeek.Monday)
            {
                return new Redirect("/");
            }

            return Content("Hello");
        }
    }
}