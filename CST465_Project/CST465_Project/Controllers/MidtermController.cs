using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace CST465_Project
{
    public class MidtermController : Controller
    {
        private class TestQuestionData
        {
            public int id { get; set; }
            public string type { get; set; }
            public string question { get; set; }
            public List<string> choices { get; set; }
        }

        private List<TestQuestion> GetQuestions()
        {
            List<TestQuestion> questions = new List<TestQuestion>();
            string json = "";
            using (StreamReader reader = new StreamReader(Server.MapPath("/JSON/Midterm.json")))
            {
                json = reader.ReadToEnd();
            }
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<TestQuestionData> questionData = serializer.Deserialize<List<TestQuestionData>>(json);
            foreach(TestQuestionData data in questionData)
            {
                switch(data.type)
                {
                    case "TrueFalseQuestion":
                        TrueFalseQuestion q1 = new TrueFalseQuestion();
                        q1.ID = data.id;
                        q1.Question = data.question;
                        questions.Add(q1);
                        break;
                    case "ShortAnswerQuestion":
                        ShortAnswerQuestion q2 = new ShortAnswerQuestion();
                        q2.ID = data.id;
                        q2.Question = data.question;
                        questions.Add(q2);
                        break;
                    case "LongAnswerQuestion":
                        LongAnswerQuestion q3 = new LongAnswerQuestion();
                        q3.ID = data.id;
                        q3.Question = data.question;
                        questions.Add(q3);
                        break;
                    case "MultipleChoiceQuestion":
                        MultipleChoiceQuestion q4 = new MultipleChoiceQuestion();
                        q4.ID = data.id;
                        q4.Question = data.question;
                        q4.Choices = data.choices;
                        questions.Add(q4);
                        break;
                }
            }
            return (questions);
        }
        
        [HttpGet]
        public ActionResult TakeTest()
        {
            List<TestQuestion> questions = GetQuestions();
            return View(questions);
        }

        [HttpPost]
        public ActionResult TakeTest(List<TestQuestion> answers)
        {
            List<TestQuestion> actualQuestions = GetQuestions();
            foreach(TestQuestion q in answers)
            {
                actualQuestions.Where(lambda => lambda.ID == q.ID).FirstOrDefault().Answer = q.Answer;
            }
            TempData["TestData"] = actualQuestions;
            return RedirectToAction("DisplayResults");
        }
         
        [HttpGet]
        public ActionResult DisplayResults()
        {
            List<TestQuestion> questions = (List<TestQuestion>)TempData["TestData"];
            TempData["TestData"] = questions;
            return View(questions);
        }
    }
}