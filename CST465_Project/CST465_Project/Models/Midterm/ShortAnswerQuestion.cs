using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CST465_Project
{
    public class ShortAnswerQuestion : TestQuestion
    {
        private string _answer;

        [Required]
        [StringLength(100)]
        public override string Answer { get; set; }
    }
}