using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentFeedbackTracker.Models
{
    public class CourseSubject
    {
        public int CourseId { get; set; }
        public int SubjectId { get; set; }

        public Course Course { get; set; }
        public Subject Subject { get; set; }
    }
}
