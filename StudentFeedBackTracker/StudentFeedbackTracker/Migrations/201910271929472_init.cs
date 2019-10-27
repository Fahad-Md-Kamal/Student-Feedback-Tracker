namespace StudentFeedbackTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.StudentAssessments",
                c => new
                    {
                        Student_Id = c.Int(nullable: false),
                        Assessment_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Student_Id, t.Assessment_Id })
                .ForeignKey("dbo.Users", t => t.Student_Id, cascadeDelete: true)
                .ForeignKey("dbo.Assessments", t => t.Assessment_Id, cascadeDelete: true)
                .Index(t => t.Student_Id)
                .Index(t => t.Assessment_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentAssessments", "Assessment_Id", "dbo.Assessments");
            DropForeignKey("dbo.StudentAssessments", "Student_Id", "dbo.Users");
            DropIndex("dbo.StudentAssessments", new[] { "Assessment_Id" });
            DropIndex("dbo.StudentAssessments", new[] { "Student_Id" });
            DropTable("dbo.StudentAssessments");
        }
    }
}
