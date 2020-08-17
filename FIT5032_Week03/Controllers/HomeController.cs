using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FIT5032_Week03.HelloWorld;
using FIT5032_Week03.Exercise;

namespace FIT5032_Week03.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            Hello hello = new Hello();
            ViewBag.Message = hello.GetHello();

            ExampleDictionary exam = new ExampleDictionary();
            exam.Example();

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}