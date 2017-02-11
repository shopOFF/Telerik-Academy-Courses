using System;
using System.Data.Entity;
using StudentSystem.Data;
using StudentSystem.Models;
using StudentSystem.Data.Migrations;

namespace StudentsSystem.ConsoleClient
{
    public class StartUp
    {
        public static void Main()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentDbContext, Configuration>());

            using (var db = new StudentDbContext())
            {
                var course = new Course
                {
                    Name = "HQC",
                    Description = "Learn fundamental computer programming knowledge and skills",
                    Materials = "Random materials"
                };

                var homework = new Homework
                {
                    Content = "Homework content is secret",
                    TimeSent = DateTime.Now
                };

                var student = new Student
                {
                    Name = "Haralampi Lampev",
                    Number = new Random().Next(0, 99999),
                    Information = new StudentAdditionalInfo
                    {
                        Age = new Random().Next(18, 120),
                        Country = "Bulgaria"
                    }
                };

                db.Courses.Add(course);
                db.Homeworks.Add(homework);
                db.Students.Add(student);
                db.SaveChanges();
            }
        }
    }
}
