using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudnetFeedbackTracker.Models
{
    public class StudentsCourse
    {
        public int SId { get; set; }
        public User Student { get; set; }

        public int CId { get; set; }
        public Course Course { get; set; }
    }
}
