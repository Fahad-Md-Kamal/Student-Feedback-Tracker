using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudnetFeedbackTracker.Models
{
    public class Feedback
    {
        [Key]
        public int Id { get; set; }
        [StringLength(250)]
        public string Detail { get; set; }
        public DateTime SubmissionDate { get; set; }
        public int Grade { get; set; }

        public virtual FeedbackType FeedbackType { get; set; }

        public virtual Module Subject { get; set; }
        public virtual User Instructor { get; set; }
        public virtual User Student { get; set; }


        void AddFeedback() { } // Admin & Staff
        void UpdateFeedback() { } // Admin & Staff
        void DeleteFeedback() { } // Admin & Staff


        void SearchBySubject() { }
        void SearchByGrade() { }
        void SearchByText() { }
        void SearchByKeywordAND() { }
        void SearchBySubmissionDate() { }
        void SearchByAssessment() { }

    }
}
