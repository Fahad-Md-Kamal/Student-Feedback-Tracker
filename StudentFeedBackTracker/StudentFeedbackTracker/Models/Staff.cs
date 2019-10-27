using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudentFeedbackTracker.Models
{
    public class Staff : User
    {
        [Key]
        public int StaffId { get; set; }


        public IList<Subject> Subjects { get; set; }
        public IList<Assessment> Assessments { get; set; }
    }
}