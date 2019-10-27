using StudentFeedbackTracker.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentFeedbackTracker
{
    public class ModelContext: DbContext
    {
        public ModelContext():base("name=con"){}

        public DbSet<Assessment> Assessments { get; set; }
        public DbSet<AssessmentType> AssessmentTypes { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<FeedbackType> FeedbackTypes { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Subject> Subjects { get; set; }

    }
}


