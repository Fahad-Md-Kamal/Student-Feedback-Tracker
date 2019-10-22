using StudnetFeedbackTracker.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudnetFeedbackTracker
{
    public class AppContext : DbContext
    {
        public AppContext() : base("name=con") { }

        public DbSet<User> Users { get; set; }
        public DbSet<UserType> UserTypes { get; set; }
        public DbSet<Assessment> Assessments { get; set; }
        public DbSet<AssessmentType> AssessmentTypes { get; set; }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<FeedbackType> FeedbackTypes { get; set; }
        public DbSet<PersonalNote> PersonalNotes { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<WordCloud> WordClouds { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Assessment>()
                .HasMany(t => t.Students)
                .WithMany(t => t.Assessments)
                .Map(m =>
               {
                   m.ToTable("AssessmentCourses");
                   m.MapLeftKey("StudentId");
                   m.MapRightKey("CourseId");
               });


            modelBuilder.Entity<Course>()
                .HasMany(t => t.Staffs)
                .WithMany(t => t.StaffsCourses)
                .Map(m =>
                {
                    m.ToTable("StaffCourse");
                    m.MapLeftKey("CourseId");
                    m.MapRightKey("StaffId");
                });


            modelBuilder.Entity<Course>()
                .HasMany(t => t.Students)
                .WithMany(t => t.StudentsCourses)
                .Map(m =>
                {
                    m.ToTable("CourseStudent");
                    m.MapLeftKey("CourseId");
                    m.MapRightKey("StudentId");
                });


            modelBuilder.Entity<Module>()
                .HasMany(t => t.Courses)
                .WithMany(t => t.Modules)
                .Map(m =>
                {
                    m.ToTable("CourseModules");
                    m.MapLeftKey("CourseId");
                    m.MapRightKey("ModuleId");
                });

        }
        
    }
}
