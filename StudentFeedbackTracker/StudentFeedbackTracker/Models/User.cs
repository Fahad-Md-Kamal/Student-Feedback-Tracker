using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudnetFeedbackTracker.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string Username { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(150)]
        public string LastName { get; set; }

        [StringLength(250)]
        public string Email { get; set; }

        [StringLength(250)]
        public string Password { get; set; }
        public string JoinDate { get; set; }

        public virtual UserType UserType { get; set; }

        public virtual IList<Assessment> Assessments { get; set; }
        public virtual IList<Course> StaffsCourses { get; set; }
        public virtual IList<Course> StudentsCourses { get; set; }

        public void UpdateUserInfo() { }
        void AddUser() { }
        void UpdateUser() { }
        void DeleteUser() { }

    }
}
