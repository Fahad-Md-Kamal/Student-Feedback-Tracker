using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudnetFeedbackTracker.Models
{
    public class Student: User
    {
        public virtual IList<Assessment> Assessments { get; set; }
        public virtual IList<Course> StudentsCourses { get; set; }
    }
}
