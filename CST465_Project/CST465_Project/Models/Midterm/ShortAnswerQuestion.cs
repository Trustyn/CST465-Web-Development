using System.ComponentModel.DataAnnotations;

namespace CST465_Project
{
    public class ShortAnswerQuestion : TestQuestion
    {
        [Required]
        [StringLength(100)]
        public override string Answer { get; set; }
    }
}