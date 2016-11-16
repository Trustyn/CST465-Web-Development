using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace CST465_Project
{
    public class TrueFalseQuestion : TestQuestion
    {
        [Required]
        [RegularExpression("True|False")]
        public override string Answer { get; set; }

        public List<SelectListItem> Choices
        {
            get
            {
                return new List<SelectListItem>
                {
                    new SelectListItem() { Text = "True", Value = "True" },
                    new SelectListItem() { Text = "False", Value = "False" }
                };
            }
        }
    }
}