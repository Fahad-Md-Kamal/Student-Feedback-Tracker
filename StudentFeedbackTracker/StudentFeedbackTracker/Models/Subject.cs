using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudentFeedbackTracker.Models
{
    public class Subject
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string SubjectName { get; set; }

        public int Credit { get; set; }

        public ICollection<Staff> Staffs { get; set; }
        public ICollection<Course> CourseSubjects { get; set; }
        public ICollection<Assessment> Assessments { get; set; }
    }
}