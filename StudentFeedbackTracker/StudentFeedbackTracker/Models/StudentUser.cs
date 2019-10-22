using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudnetFeedbackTracker.Models
{
    public class StudentUser : User
    {
        public List<Course> courses;
        public List<Subject> subjects { get; set; }
        public List<Assessment> Assesments { get; set; }


        public void GetEnrolledCourses() { }
        public void GetEnrolledSubjects() { }

    }
}
