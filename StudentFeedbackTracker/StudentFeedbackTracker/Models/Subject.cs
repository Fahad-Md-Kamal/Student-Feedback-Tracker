using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudnetFeedbackTracker.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string SubjectName { get; set; }

        public virtual User Staff { get; set; }
        public virtual List<CouseSubject> Courses { get; set; }


        void AddModule() { }
        void UpdateModule() { }
        void DeleteModule() { }


        public void AssignStaffToSubject() { }

    }
}
