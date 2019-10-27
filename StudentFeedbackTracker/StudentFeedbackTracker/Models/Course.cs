using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudentFeedbackTracker.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }

        [StringLength(250)]
        public string CourseName { get; set; }

        public int TotalCredit { get; set; }

        public ICollection<Staff> Students { get; set; }
        public ICollection<Subject> Subjects { get; set; }
    }
}