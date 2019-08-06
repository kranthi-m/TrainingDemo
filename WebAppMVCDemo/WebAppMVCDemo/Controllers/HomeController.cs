using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppMVCDemo.Controllers
{
    //every controller should suffix controller word
    public class HomeController : Controller
    {
        //Action methods
        public ActionResult Index()
        {
         
            return View();
        }
        public ActionResult Content()
        {
          return  Content("Hello world");
        }

        public ActionResult About()
        {
            ServiceReference1.Service1Client obj = new ServiceReference1.Service1Client();
           string msg= obj.GetData(100);
            ViewBag.Message = msg;

                return View();
            
            
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}