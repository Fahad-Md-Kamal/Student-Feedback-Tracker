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

        public IList<Staff> Staffs { get; set; }
        public IList<Course> Courses { get; set; }
        public IList<Assessment> Assessments { get; set; }
    }
}