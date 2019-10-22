namespace StudnetFeedbackTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DatabaseCreation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Assessments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AssessmentDetail = c.String(maxLength: 250),
                        CreationDate = c.DateTime(nullable: false),
                        SubmissionDate = c.DateTime(nullable: false),
                        Score = c.Int(nullable: false),
                        AssessmentType_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AssessmentTypes", t => t.AssessmentType_Id)
                .Index(t => t.AssessmentType_Id);
            
            CreateTable(
                "dbo.AssessmentTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AssessmentName = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(maxLength: 50),
                        FirstName = c.String(maxLength: 50),
                        LastName = c.String(maxLength: 150),
                        Email = c.String(maxLength: 250),
                        Password = c.String(maxLength: 250),
                        JoinDate = c.String(),
                        UserType_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserTypes", t => t.UserType_Id)
                .Index(t => t.UserType_Id);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CourseName = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Modules",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SubjectName = c.String(maxLength: 50),
                        Staff_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Staff_Id)
                .Index(t => t.Staff_Id);
            
            CreateTable(
                "dbo.UserTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Feedbacks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Detail = c.String(maxLength: 250),
                        SubmissionDate = c.DateTime(nullable: false),
                        Grade = c.Int(nullable: false),
                        FeedbackType_Id = c.Int(),
                        Instructor_Id = c.Int(),
                        Student_Id = c.Int(),
                        Subject_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FeedbackTypes", t => t.FeedbackType_Id)
                .ForeignKey("dbo.Users", t => t.Instructor_Id)
                .ForeignKey("dbo.Users", t => t.Student_Id)
                .ForeignKey("dbo.Modules", t => t.Subject_Id)
                .Index(t => t.FeedbackType_Id)
                .Index(t => t.Instructor_Id)
                .Index(t => t.Student_Id)
                .Index(t => t.Subject_Id);
            
            CreateTable(
                "dbo.FeedbackTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PersonalNotes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Note = c.String(maxLength: 300),
                        Assessment_Id = c.Int(),
                        Student_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Assessments", t => t.Assessment_Id)
                .ForeignKey("dbo.Users", t => t.Student_Id)
                .Index(t => t.Assessment_Id)
                .Index(t => t.Student_Id);
            
            CreateTable(
                "dbo.WordClouds",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Word = c.String(maxLength: 250),
                        NumberOfUse = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CourseModules",
                c => new
                    {
                        CourseId = c.Int(nullable: false),
                        ModuleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.CourseId, t.ModuleId })
                .ForeignKey("dbo.Modules", t => t.CourseId, cascadeDelete: true)
                .ForeignKey("dbo.Courses", t => t.ModuleId, cascadeDelete: true)
                .Index(t => t.CourseId)
                .Index(t => t.ModuleId);
            
            CreateTable(
                "dbo.StaffCourse",
                c => new
                    {
                        CourseId = c.Int(nullable: false),
                        StaffId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.CourseId, t.StaffId })
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.StaffId, cascadeDelete: true)
                .Index(t => t.CourseId)
                .Index(t => t.StaffId);
            
            CreateTable(
                "dbo.CourseStudent",
                c => new
                    {
                        CourseId = c.Int(nullable: false),
                        StudentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.CourseId, t.StudentId })
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.CourseId)
                .Index(t => t.StudentId);
            
            CreateTable(
                "dbo.AssessmentCourses",
                c => new
                    {
                        StudentId = c.Int(nullable: false),
                        CourseId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.StudentId, t.CourseId })
                .ForeignKey("dbo.Assessments", t => t.StudentId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.CourseId, cascadeDelete: true)
                .Index(t => t.StudentId)
                .Index(t => t.CourseId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PersonalNotes", "Student_Id", "dbo.Users");
            DropForeignKey("dbo.PersonalNotes", "Assessment_Id", "dbo.Assessments");
            DropForeignKey("dbo.Feedbacks", "Subject_Id", "dbo.Modules");
            DropForeignKey("dbo.Feedbacks", "Student_Id", "dbo.Users");
            DropForeignKey("dbo.Feedbacks", "Instructor_Id", "dbo.Users");
            DropForeignKey("dbo.Feedbacks", "FeedbackType_Id", "dbo.FeedbackTypes");
            DropForeignKey("dbo.AssessmentCourses", "CourseId", "dbo.Users");
            DropForeignKey("dbo.AssessmentCourses", "StudentId", "dbo.Assessments");
            DropForeignKey("dbo.Users", "UserType_Id", "dbo.UserTypes");
            DropForeignKey("dbo.CourseStudent", "StudentId", "dbo.Users");
            DropForeignKey("dbo.CourseStudent", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.StaffCourse", "StaffId", "dbo.Users");
            DropForeignKey("dbo.StaffCourse", "CourseId", "dbo.Courses");
            DropForeignKey("dbo.Modules", "Staff_Id", "dbo.Users");
            DropForeignKey("dbo.CourseModules", "ModuleId", "dbo.Courses");
            DropForeignKey("dbo.CourseModules", "CourseId", "dbo.Modules");
            DropForeignKey("dbo.Assessments", "AssessmentType_Id", "dbo.AssessmentTypes");
            DropIndex("dbo.AssessmentCourses", new[] { "CourseId" });
            DropIndex("dbo.AssessmentCourses", new[] { "StudentId" });
            DropIndex("dbo.CourseStudent", new[] { "StudentId" });
            DropIndex("dbo.CourseStudent", new[] { "CourseId" });
            DropIndex("dbo.StaffCourse", new[] { "StaffId" });
            DropIndex("dbo.StaffCourse", new[] { "CourseId" });
            DropIndex("dbo.CourseModules", new[] { "ModuleId" });
            DropIndex("dbo.CourseModules", new[] { "CourseId" });
            DropIndex("dbo.PersonalNotes", new[] { "Student_Id" });
            DropIndex("dbo.PersonalNotes", new[] { "Assessment_Id" });
            DropIndex("dbo.Feedbacks", new[] { "Subject_Id" });
            DropIndex("dbo.Feedbacks", new[] { "Student_Id" });
            DropIndex("dbo.Feedbacks", new[] { "Instructor_Id" });
            DropIndex("dbo.Feedbacks", new[] { "FeedbackType_Id" });
            DropIndex("dbo.Modules", new[] { "Staff_Id" });
            DropIndex("dbo.Users", new[] { "UserType_Id" });
            DropIndex("dbo.Assessments", new[] { "AssessmentType_Id" });
            DropTable("dbo.AssessmentCourses");
            DropTable("dbo.CourseStudent");
            DropTable("dbo.StaffCourse");
            DropTable("dbo.CourseModules");
            DropTable("dbo.WordClouds");
            DropTable("dbo.PersonalNotes");
            DropTable("dbo.FeedbackTypes");
            DropTable("dbo.Feedbacks");
            DropTable("dbo.UserTypes");
            DropTable("dbo.Modules");
            DropTable("dbo.Courses");
            DropTable("dbo.Users");
            DropTable("dbo.AssessmentTypes");
            DropTable("dbo.Assessments");
        }
    }
}
