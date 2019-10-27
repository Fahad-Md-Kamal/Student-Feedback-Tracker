using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudentFeedbackTracker.Models
{
    public class Assessment
    {
        [Key]
        public int Id { get; set; }

        [StringLength(250)]
        public string Detail { get; set; }

        public DateTime CreationDate { get; set; }

        public int Score { get; set; }

        public int SubjectId { get; set; }
        public Subject Subject { get; set; }

        public int StaffId { get; set; }
        public Staff Staff { get; set; }

        public int AssessmentTypeId { get; set; }
        public AssessmentType AssessmentType { get; set; }

        public ICollection<Feedback> Feedbacks { get; set; }
    }
}