using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudentFeedbackTracker.Models
{
    public class Staff : User
    {
        [Key]
        public int StaffId { get; set; }
        public int Salary { get; set; }


        public ICollection<SubjectStaff> Subjects { get; set; }
        public ICollection<Assessment> Assessments { get; set; }
    }
}