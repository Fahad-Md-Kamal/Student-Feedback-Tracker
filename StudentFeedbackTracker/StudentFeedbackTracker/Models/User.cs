using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudnetFeedbackTracker.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string JoinDate { get; set; }

        public virtual UserType UserType { get; set; }

        public virtual IList<Assessment> Assessments { get; set; }
        //public virtual IList<StaffsCourse> StaffsCourses { get; set; }
        //public virtual IList<StudentsCourse> StudentsCourses { get; set; }

        public void UpdateUserInfo() { }
        void AddUser() { }
        void UpdateUser() { }
        void DeleteUser() { }

    }
}
