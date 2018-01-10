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
            //SeedLectures(context);
            //SeedAttendaces(context);
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

        //seed lectures and each lecture teaching one subject each
        private void SeedLectures(AttendDBContext context)
        {
            context.Lectures.AddOrUpdate(
                new Lecture { LectureId = 1, LectureName = "John K" },
                new Lecture { LectureId = 2, LectureName = "Kathy B" }
             );

            context.LectureSubjects.AddOrUpdate(
                new LectureSubject { LectureId = 1, SubjectId = 1 },
                new LectureSubject { LectureId = 2, SubjectId = 8 }
            );
        }

        //seed attendance
        private void SeedAttendaces(AttendDBContext  context)
        {
            context.Attendances.AddOrUpdate(
                new Attendance { AttendanceId = 1, AttendanceDate = DateTime.Now, SubjectId = 1, StudentId = "S01", Present = true },
                new Attendance { AttendanceId = 2, AttendanceDate = DateTime.Now, SubjectId = 2, StudentId = "S01", Present = false },
                new Attendance { AttendanceId = 3, AttendanceDate = DateTime.Now, SubjectId = 3, StudentId = "S02", Present = true },
                new Attendance { AttendanceId = 4, AttendanceDate = DateTime.Now, SubjectId = 8, StudentId = "S02", Present = true }
                );
        }
        

    }
}
