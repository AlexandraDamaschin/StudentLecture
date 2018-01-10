namespace StudentLecture.Migrations.AttendMigrations
{
    using Models.StudentLectureModels;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Models.StudentLectureModels.AttendDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations.AttendMigrations";
        }

        protected override void Seed(Models.StudentLectureModels.AttendDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            //SeedSubjects(context);
            //SeedStudents(context);
            //SeedStudentSubjects(context);
        }

        private void SeedSubjects (AttendDBContext context)
        {
            context.Subjects.AddOrUpdate(
                s => s.SubjectId,
                new Subject { SubjectName = "RAD" },
                new Subject { SubjectName = "Web" },
                new Subject { SubjectName = "Database" },
                new Subject { SubjectName = "Soft Prj Mgm" }
                );
        }
        //when to put context.saveChanges()?

        //seed students
        private void SeedStudents(AttendDBContext context)
        {
            context.Students.AddOrUpdate(
                  p => p.StudentId,
                  new Student { StudentId = "S01", FirstName="Josh", LastName="Knock" },
                  new Student { StudentId = "S02", FirstName = "Marry", LastName = "Lee" }
                );
        }

        //seed student subjects
        private void SeedStudentSubjects(AttendDBContext context)
        {
            context.StudentSubjects.AddOrUpdate(
                new StudentSubject { StudentId = "S01", SubjectId = 1 },
                new StudentSubject { StudentId = "S01", SubjectId = 2 },
                new StudentSubject { StudentId = "S02", SubjectId = 3 },
                new StudentSubject { StudentId = "S02", SubjectId = 8 }
             );
        }

    }
}
