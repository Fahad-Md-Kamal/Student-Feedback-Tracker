namespace StudentFeedbackTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Assessments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Detail = c.String(maxLength: 250),
                        CreationDate = c.DateTime(nullable: false),
                        Score = c.Int(nullable: false),
                        SubjectId = c.Int(nullable: false),
                        StaffId = c.Int(nullable: false),
                        AssessmentTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AssessmentTypes", t => t.AssessmentTypeId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.StaffId, cascadeDelete: true)
                .ForeignKey("dbo.Subjects", t => t.SubjectId, cascadeDelete: true)
                .Index(t => t.SubjectId)
                .Index(t => t.StaffId)
                .Index(t => t.AssessmentTypeId);
            
            CreateTable(
                "dbo.AssessmentTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AssessementType = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Feedbacks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FeedbackDetails = c.String(maxLength: 300),
                        FeedbackDate = c.DateTime(nullable: false),
                        SubjectId = c.Int(nullable: false),
                        FeedbackTypeId = c.Int(nullable: false),
                        StaffId = c.Int(nullable: false),
                        Assessment_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FeedbackTypes", t => t.FeedbackTypeId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.StaffId, cascadeDelete: true)
                .ForeignKey("dbo.Subjects", t => t.SubjectId, cascadeDelete: true)
                .ForeignKey("dbo.Assessments", t => t.Assessment_Id)
                .Index(t => t.SubjectId)
                .Index(t => t.FeedbackTypeId)
                .Index(t => t.StaffId)
                .Index(t => t.Assessment_Id);
            
            CreateTable(
                "dbo.FeedbackTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FeedbackTypeName = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Notes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Details = c.String(maxLength: 250),
                        StudentId = c.Int(nullable: false),
                        Feedback_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.StudentId, cascadeDelete: true)
                .ForeignKey("dbo.Feedbacks", t => t.Feedback_Id)
                .Index(t => t.StudentId)
                .Index(t => t.Feedback_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(maxLength: 250),
                        Email = c.String(maxLength: 200),
                        Password = c.String(maxLength: 20),
                        DoB = c.DateTime(nullable: false),
                        FirstName = c.String(maxLength: 250),
                        LastName = c.String(maxLength: 250),
                        Address = c.String(maxLength: 250),
                        RoleId = c.Int(nullable: false),
                        StudentId = c.Int(),
                        StaffId = c.Int(),
                        Salary = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Course_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Roles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.Courses", t => t.Course_Id)
                .Index(t => t.RoleId)
                .Index(t => t.Course_Id);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CourseName = c.String(maxLength: 250),
                        TotalCredit = c.Int(nullable: false),
                        Student_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Student_Id)
                .Index(t => t.Student_Id);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoleName = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SubjectName = c.String(maxLength: 50),
                        Credit = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SubjectCourses",
                c => new
                    {
                        Subject_Id = c.Int(nullable: false),
                        Course_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Subject_Id, t.Course_Id })
                .ForeignKey("dbo.Subjects", t => t.Subject_Id, cascadeDelete: true)
                .ForeignKey("dbo.Courses", t => t.Course_Id, cascadeDelete: true)
                .Index(t => t.Subject_Id)
                .Index(t => t.Course_Id);
            
            CreateTable(
                "dbo.SubjectStaffs",
                c => new
                    {
                        Subject_Id = c.Int(nullable: false),
                        Staff_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Subject_Id, t.Staff_Id })
                .ForeignKey("dbo.Subjects", t => t.Subject_Id, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.Staff_Id, cascadeDelete: true)
                .Index(t => t.Subject_Id)
                .Index(t => t.Staff_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Feedbacks", "Assessment_Id", "dbo.Assessments");
            DropForeignKey("dbo.Feedbacks", "SubjectId", "dbo.Subjects");
            DropForeignKey("dbo.Feedbacks", "StaffId", "dbo.Users");
            DropForeignKey("dbo.Notes", "Feedback_Id", "dbo.Feedbacks");
            DropForeignKey("dbo.Notes", "StudentId", "dbo.Users");
            DropForeignKey("dbo.Courses", "Student_Id", "dbo.Users");
            DropForeignKey("dbo.Users", "Course_Id", "dbo.Courses");
            DropForeignKey("dbo.SubjectStaffs", "Staff_Id", "dbo.Users");
            DropForeignKey("dbo.SubjectStaffs", "Subject_Id", "dbo.Subjects");
            DropForeignKey("dbo.SubjectCourses", "Course_Id", "dbo.Courses");
            DropForeignKey("dbo.SubjectCourses", "Subject_Id", "dbo.Subjects");
            DropForeignKey("dbo.Assessments", "SubjectId", "dbo.Subjects");
            DropForeignKey("dbo.Users", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.Assessments", "StaffId", "dbo.Users");
            DropForeignKey("dbo.Feedbacks", "FeedbackTypeId", "dbo.FeedbackTypes");
            DropForeignKey("dbo.Assessments", "AssessmentTypeId", "dbo.AssessmentTypes");
            DropIndex("dbo.SubjectStaffs", new[] { "Staff_Id" });
            DropIndex("dbo.SubjectStaffs", new[] { "Subject_Id" });
            DropIndex("dbo.SubjectCourses", new[] { "Course_Id" });
            DropIndex("dbo.SubjectCourses", new[] { "Subject_Id" });
            DropIndex("dbo.Courses", new[] { "Student_Id" });
            DropIndex("dbo.Users", new[] { "Course_Id" });
            DropIndex("dbo.Users", new[] { "RoleId" });
            DropIndex("dbo.Notes", new[] { "Feedback_Id" });
            DropIndex("dbo.Notes", new[] { "StudentId" });
            DropIndex("dbo.Feedbacks", new[] { "Assessment_Id" });
            DropIndex("dbo.Feedbacks", new[] { "StaffId" });
            DropIndex("dbo.Feedbacks", new[] { "FeedbackTypeId" });
            DropIndex("dbo.Feedbacks", new[] { "SubjectId" });
            DropIndex("dbo.Assessments", new[] { "AssessmentTypeId" });
            DropIndex("dbo.Assessments", new[] { "StaffId" });
            DropIndex("dbo.Assessments", new[] { "SubjectId" });
            DropTable("dbo.SubjectStaffs");
            DropTable("dbo.SubjectCourses");
            DropTable("dbo.Subjects");
            DropTable("dbo.Roles");
            DropTable("dbo.Courses");
            DropTable("dbo.Users");
            DropTable("dbo.Notes");
            DropTable("dbo.FeedbackTypes");
            DropTable("dbo.Feedbacks");
            DropTable("dbo.AssessmentTypes");
            DropTable("dbo.Assessments");
        }
    }
}
