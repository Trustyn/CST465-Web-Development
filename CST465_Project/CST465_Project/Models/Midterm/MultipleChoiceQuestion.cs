using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace CST465_Project
{
    public class MultipleChoiceQuestion : TestQuestion
    {
        private List<string> _answer;

        [Required]
        public override string Answer { get; set; }
    }
}