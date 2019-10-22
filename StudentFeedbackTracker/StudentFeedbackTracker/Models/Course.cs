using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudnetFeedbackTracker.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string CourseName { get; set; }

        public virtual ICollection<Module> Modules { get; set; }
        public virtual ICollection<User> Students { get; set; }
        public virtual ICollection<User> Staffs { get; set; }


        void AddCourse() { }
        void UpdateCourse() { }
        void DeleteCourse() { }

        void AddSubjectToTheCourse() { }
    }
}
