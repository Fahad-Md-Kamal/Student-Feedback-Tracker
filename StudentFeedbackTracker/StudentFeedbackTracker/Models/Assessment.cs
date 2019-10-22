using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudnetFeedbackTracker.Models
{
    public class Assessment
    {
        public int Id { get; set; }
        public string AssessmentDetail { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime SubmissionDate { get; set; }
        public int Score { get; set; }

        public virtual AssessmentType AssessmentType { get; set; }
        //public virtual Subject Subeject { get; set; }
        //public virtual User Staff { get; set; }

        public virtual IList<User> Students { get; set; }

        public void AddAssessement() { } // Admin, Staff
        public void UpdateAssessement() { } // Admi, Staff
        public void DeleteAssessement() { } // Admin, Staff
        void SeeGradesBreakdown() { } // Staff ====================        Bar Chart

    }
}
