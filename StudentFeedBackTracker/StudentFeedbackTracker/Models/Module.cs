using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudnetFeedbackTracker.Models
{
    public class Module
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string SubjectName { get; set; }

        public virtual User Staff { get; set; }
        public virtual List<Course> Courses { get; set; }


        void AddModule() { }
        void UpdateModule() { }
        void DeleteModule() { }


        public void AssignStaffToSubject() { }

    }
}
