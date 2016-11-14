using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CST465_Project
{
    public class LongAnswerQuestion : TestQuestion
    {
        private string _answer;

        [Required]
        public override string Answer { get; set; }
    }
}