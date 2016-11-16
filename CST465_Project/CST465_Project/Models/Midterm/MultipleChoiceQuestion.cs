using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace CST465_Project
{
    public class MultipleChoiceQuestion : TestQuestion
    {

        [Required]
        public override string Answer { get; set; }
  
        public List<string> Choices { get; set; }
    }
}