using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudnetFeedbackTracker.Models
{
    public class AssessmentStudent
    {
        public int AId { get; set; }
        public Assessment Assessment { get; set; }

        public int SId { get; set; }
        public User Student { get; set; }
    }
}
