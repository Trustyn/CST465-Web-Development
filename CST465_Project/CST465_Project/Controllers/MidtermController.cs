using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CST465_Project
{
    public class MidtermController : Controller
    {
        private List<TestQuestion> _TQ;

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult TakeTest()
        {
            //Return a view with the list of TestQuestion objects
            return View(_TQ);
        }

        //[HttpPost]
        //public ActionResult TakeTest()
        //{
            //1.Prevent against cross site request forgery
            //2.Retrieve the questions/answers from the JSON file again,
            //becasue the posted data will not contain the question text.
            //3.Match up the list of ids/questions and the list of ids/answers that was
            //posted based on ID and make one of them into a list that has ids/questions/answers
            //4.Verify that the model meets validation rules.
            //If validation succeeds -Set TempData["TestData"] = the list of ids/questions/answers
            //-Redirect to the displayResults action
            //Otherwise return the View function, passing in the list with ids/questions/answers


        //    return View();
        //}

        [HttpGet]
        public ActionResult DisplayResults()
        {
            //1.Retrieve the list of TestQuestions from TempData
            //2.Return the View, passing in the list of TestQuestions

            return View();
        }
    }
}