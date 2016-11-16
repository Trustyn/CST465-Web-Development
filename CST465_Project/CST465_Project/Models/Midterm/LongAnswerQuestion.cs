using System.ComponentModel.DataAnnotations;

namespace CST465_Project
{
    public class LongAnswerQuestion : TestQuestion
    {
        [Required]
        public override string Answer { get; set; }
    }
}