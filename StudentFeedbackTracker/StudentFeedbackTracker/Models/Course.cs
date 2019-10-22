using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudnetFeedbackTracker.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public List<Subject> CourseSubjects { get; set; }
        public List<StudentUser> CourseSutdents { get; set; }

        void AddSubjectToTheCourse() { }
        // StudentList
    }
}
