using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudnetFeedbackTracker.Models
{
    public class Assessment
    {
        [Key]
        public int Id { get; set; }

        [StringLength(250)]
        public string AssessmentDetail { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime SubmissionDate { get; set; }
        public int Score { get; set; }

        public virtual AssessmentType AssessmentType { get; set; }

        public virtual IList<Student> Students { get; set; }
        public virtual Staff Staff { get; set; }

        public void AddAssessement() { } // Admin, Staff
        public void UpdateAssessement() { } // Admi, Staff
        public void DeleteAssessement() { } // Admin, Staff
        void SeeGradesBreakdown() { } // Staff ====================        Bar Chart

    }
}
