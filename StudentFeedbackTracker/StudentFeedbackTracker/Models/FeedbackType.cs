using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudentFeedbackTracker.Models
{
    public class FeedbackType
    {
        [Key]
        public int Id { get; set; }

        [StringLength(20)]
        public string FeedbackTypeName { get; set; }

        public ICollection<Feedback> Feedbacks { get; set; }
    }
}