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

        public virtual ICollection<CouseSubject> Subjects { get; set; }
        public virtual ICollection<StudentsCourse> StudentsCourses { get; set; }
        public virtual ICollection<StaffsCourse> StaffsCourses { get; set; }


        void AddCourse() { }
        void UpdateCourse() { }
        void DeleteCourse() { }

        void AddSubjectToTheCourse() { }
    }
}
