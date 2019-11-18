using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWithWebApi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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



        //this action mtd is for loadin the create product feature
        //as the part of ajax operation
        public ActionResult CreateProduct()
        {
            //we are returnin the partial view not the full view as we do not want
            //the header and footer parts to b ther. The header and footer is
            // already visible as the part of home or index request. We just want 
            // to create view to b inserted into index view

            return PartialView();

        }
    }
}