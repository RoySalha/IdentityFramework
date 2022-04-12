using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IdentityFramework.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //enable-migrations || it is depricated in new version
            //add-migration || it will generate migration file in Migrations folder with a specific name
            //update-database || it will take the last migration file and update the database based on it

            ////note: to undo specific migration you need to delete the file from Migrations folder 
            ////also you can at any time delete the whole folder and add migration at the point that you want
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}