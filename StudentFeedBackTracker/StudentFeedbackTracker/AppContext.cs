//using StudnetFeedbackTracker.Models;
//using System;
//using System.Collections.Generic;
//using System.Data.Entity;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace StudnetFeedbackTracker
//{
//    public class AppContext : DbContext
//    {
//        public AppContext(): base("name=con"){ }


//        public DbSet<Assessment> Assessments { get; set; }
//        public DbSet<AssessmentType> AssessmentTypes { get; set; }

//        //public DbSet<AssessmentStudent> AssessmentStudents { get; set; }
//        //public DbSet<Course> Courses { get; set; }
//        //public DbSet<CouseSubject> CouseSubjects { get; set; }
//        //public DbSet<Feedback> Feedbacks { get; set; }
//        //public DbSet<FeedbackType> FeedbackTypes { get; set; }
//        //public DbSet<PersonalNote> PersonalNotes { get; set; }
//        //public DbSet<StaffsCourse> StaffsCourses { get; set; }
//        //public DbSet<StudentsCourse> StudentsCourses { get; set; }
//        //public DbSet<Subject> Subjects { get; set; }
//        public DbSet<User> Users { get; set; }
//        public DbSet<UserType> UserTypes { get; set; }
//        //public DbSet<WordCloud> wordClouds { get; set; }


//        protected override void OnModelCreating(DbModelBuilder modelBuilder)
//        {
//            base.OnModelCreating(modelBuilder);

//            modelBuilder.Entity<Assessment>()
//                .HasMany(t => t.Students)
//                .WithMany(t => t.Assessments)
//                .Map(m =>
//               {
//                   m.ToTable("AssessmentCourses");
//                   m.MapLeftKey("StudentId");
//                   m.MapRightKey("CourseId");
//               });


//        }



//    }
//}
