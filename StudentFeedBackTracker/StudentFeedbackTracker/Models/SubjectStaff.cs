using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentFeedbackTracker.Models
{
    public class SubjectStaff
    {
        public int StaffId { get; set; }
        public int SubjectId { get; set; }

        public Staff Staff { get; set; }
        public Subject Subject { get; set; }
    }
}
