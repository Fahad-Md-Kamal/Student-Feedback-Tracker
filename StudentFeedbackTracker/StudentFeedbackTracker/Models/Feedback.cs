using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudentFeedbackTracker.Models
{
    public class Feedback
    {
        [Key]
        public int Id { get; set; }

        [StringLength(300)]
        public string FeedbackDetails { get; set; }
        public DateTime FeedbackDate { get; set; }

        public Subject Subject { get; set; }
        public FeedbackType FeedbackType { get; set; }
        public Staff Staff { get; set; }

        public IList<Note> Notes { get; set; }
    }
}