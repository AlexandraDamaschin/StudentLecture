namespace StudentLecture.Migrations.AttendMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetIdentityNone : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.StudentSubject", "StudentId", "dbo.Student");
            DropForeignKey("dbo.Attendance", "StudentId", "dbo.Student");
            DropPrimaryKey("dbo.Student");
            AlterColumn("dbo.Student", "StudentId", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Student", "StudentId");
            AddForeignKey("dbo.StudentSubject", "StudentId", "dbo.Student", "StudentId", cascadeDelete: true);
            AddForeignKey("dbo.Attendance", "StudentId", "dbo.Student", "StudentId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Attendance", "StudentId", "dbo.Student");
            DropForeignKey("dbo.StudentSubject", "StudentId", "dbo.Student");
            DropPrimaryKey("dbo.Student");
            AlterColumn("dbo.Student", "StudentId", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Student", "StudentId");
            AddForeignKey("dbo.Attendance", "StudentId", "dbo.Student", "StudentId");
            AddForeignKey("dbo.StudentSubject", "StudentId", "dbo.Student", "StudentId", cascadeDelete: true);
        }
    }
}
