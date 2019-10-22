namespace StudnetFeedbackTracker
{
    using StudnetFeedbackTracker.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class StudentFeedbackTracker : DbContext
    {
        // Your context has been configured to use a 'StudentFeedbackTracker' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'StudnetFeedbackTracker.StudentFeedbackTracker' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'StudentFeedbackTracker' 
        // connection string in the application configuration file.
        public StudentFeedbackTracker()
            : base("name=StudentFeedbackTracker1")
        { }
        public DbSet<Assessment> Assessments { get; set; }
        public DbSet<AssessmentType> AssessmentTypes { get; set; }
        //public DbSet<AssessmentStudent> AssessmentStudents { get; set; }
        //public DbSet<Course> Courses { get; set; }
        //public DbSet<CouseSubject> CouseSubjects { get; set; }
        //public DbSet<Feedback> Feedbacks { get; set; }
        //public DbSet<FeedbackType> FeedbackTypes { get; set; }
        //public DbSet<PersonalNote> PersonalNotes { get; set; }
        //public DbSet<StaffsCourse> StaffsCourses { get; set; }
        //public DbSet<StudentsCourse> StudentsCourses { get; set; }
        //public DbSet<Subject> Subjects { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserType> UserTypes { get; set; }
        //public DbSet<WordCloud> wordClouds { get; set; }




        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Assessment>()
                .HasMany(t => t.Students)
                .WithMany(t => t.Assessments)
                .Map(m =>
                {
                    m.ToTable("AssessmentCourses");
                    m.MapLeftKey("StudentId");
                    m.MapRightKey("CourseId");
                });
        }


        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}