using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudnetFeedbackTracker.Models
{
    public abstract class Feedback
    {
        public int Id { get; set; }
        public string Detail { get; set; }
        public DateTime SubmissionDate { get; set; }
        public int Grade { get; set; }
        

        public virtual FeedbackType FeedbackType { get; set; }
        public virtual Subject Subject { get; set; }
        public virtual StaffUser Instructor { get; set; }
        public virtual StudentUser Student { get; set; }


        void AddFeedback() { }
        void UpdateFeedback() { }
        void DeleteFeedback() { }

        void SearchBySubject() { }
        void SearchByGrade() { }
        void SearchByText() { }
        void SearchByKeywordAND() { }
        void SearchBySubmissionDate() { }
        void SearchByAssessment() { }

    }
}
