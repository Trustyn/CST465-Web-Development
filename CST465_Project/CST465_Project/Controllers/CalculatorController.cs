using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CST465_Project
{
    public class CalculatorController : Controller
    {
        
        // GET: Calculator
        public ActionResult Index()
        {
            //Calc c = new Calc();
            return View();
        }
    }
}