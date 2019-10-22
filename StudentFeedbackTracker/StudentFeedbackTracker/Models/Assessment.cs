using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudnetFeedbackTracker.Models
{
    public abstract class Assessment
    {
        public int Id { get; set; }
        public string AssessmentDetail { get; set; }
        public DateTime CreationDate { get; set; }
        public int Score { get; set; }

        public virtual AssessmentType AssessmentType { get; set; }
        public virtual Subject Subeject { get; set; }
        public virtual StudentUser Student { get; set; }
        public virtual StaffUser Staff { get; set; }
    }
}
