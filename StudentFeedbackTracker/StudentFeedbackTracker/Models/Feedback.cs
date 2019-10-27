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

        public int SubjectId { get; set; }
        public Subject Subject { get; set; }

        public int FeedbackTypeId { get; set; }
        public FeedbackType FeedbackType { get; set; }

        public int StaffId { get; set; }
        public Staff Staff { get; set; }

        public ICollection<Note> Notes { get; set; }
    }
}