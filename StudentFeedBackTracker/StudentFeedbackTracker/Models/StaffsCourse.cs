using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudnetFeedbackTracker.Models
{
    public class StaffsCourse
    {
        public int SId { get; set; }
        public User Staff { get; set; }

        public int CId { get; set; }
        public Course Course { get; set; }
    }
}
