using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudnetFeedbackTracker.Models
{
    public class StaffUser : User
    {
        public List<Subject> AssignedSubjects { get; set; }


        void AddAssessment() { }
        void AddFeedback() { }
        void AddRecommandation() { }
        void SeeGradesBreakdown() { }
        void SeeWordCoud() { }
        
    }
}
