using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentFeedbackTracker.Models
{
    public class Student : User
    {
        [Key]
        public int StudentId { get; set; }

        public ICollection<Course> Courses { get; set; }
        public ICollection<Note> Notes { get; set; }
        public ICollection<Assessment> Assessments { get; set; }
    }
}
