namespace School.Test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Collections.Generic;

    [TestClass]
    public class CourseTests
    {
        private const int MaximumNumberOfStudentsInACourse = 29;

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddStudentToCourseMethodShouldThrowArgumentNullExceptionWhenNullIsPassedToIt()
        {
            var testCourse = new Course();

            testCourse.AddStudentToCourse(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ApplicationException))]
        public void AddStudentToCourseMethodShouldThrowApplicationExceptionWhenStudentsAreMoreThen29()
        {
            Course courses = new Course();
            courses.AddStudentToCourse(new Student("Robert Robertov", 50000));
            courses.AddStudentToCourse(new Student("Tisho Tishov", 20020));
            courses.AddStudentToCourse(new Student("Koko Kokov", 50000));
            courses.AddStudentToCourse(new Student("Jordan Jordanov", 60000));
            courses.AddStudentToCourse(new Student("Luna Lunava", 70000));
            courses.AddStudentToCourse(new Student("Eva Mendez", 10000));
            courses.AddStudentToCourse(new Student("Ivan Ivanov", 20000));
            courses.AddStudentToCourse(new Student("Lorem Ipsumov", 20001));
            courses.AddStudentToCourse(new Student("Pesho Peshov", 10000));
            courses.AddStudentToCourse(new Student("Petar Petrov", 11000));
            courses.AddStudentToCourse(new Student("Robert Robertov", 51000));
            courses.AddStudentToCourse(new Student("Tisho Tishov", 30020));
            courses.AddStudentToCourse(new Student("Koko Kokov", 35000));
            courses.AddStudentToCourse(new Student("Jordan Jordanov", 60101));
            courses.AddStudentToCourse(new Student("Luna Lunava", 70200));
            courses.AddStudentToCourse(new Student("Eva Mendez", 10030));
            courses.AddStudentToCourse(new Student("Ivan Ivanov", 20100));
            courses.AddStudentToCourse(new Student("Lorem Ipsumov", 29001));
            courses.AddStudentToCourse(new Student("Pesho Peshov", 11200));
            courses.AddStudentToCourse(new Student("Petar Petrov", 11030));
            courses.AddStudentToCourse(new Student("Robert Robertov", 58000));
            courses.AddStudentToCourse(new Student("Tisho Tishov", 20029));
            courses.AddStudentToCourse(new Student("Koko Kokov", 30770));
            courses.AddStudentToCourse(new Student("Jordan Jordanov", 60660));
            courses.AddStudentToCourse(new Student("Luna Lunava", 70066));
            courses.AddStudentToCourse(new Student("Eva Mendez", 10760));
            courses.AddStudentToCourse(new Student("Ivan Ivanov", 20430));
            courses.AddStudentToCourse(new Student("Lorem Ipsumov", 27001));
            courses.AddStudentToCourse(new Student("Pesho Peshov", 10060));
            courses.AddStudentToCourse(new Student("Petar Petrov", 17770));
        }

        [TestMethod]
        public void AddStudentToCourseMethodShouldJoinStudentsToCourseCorrectly()
        {
            // Arrange
            Course courses = new Course();
            // Act 
            courses.AddStudentToCourse(new Student("Robert Robertov", 50000));
            courses.AddStudentToCourse(new Student("Tisho Tishov", 20020));
            courses.AddStudentToCourse(new Student("Koko Jambov", 30000));
            // Assert
            Assert.AreEqual(3, courses.StudentsList.Count);
        }

        [TestMethod]
        public void RemoveStudentFromCourseMethodShouldRemoveStudentsFromCourseCorrectly()
        {
            // Arrange
            var courses = new Course();
            var studentGosho = new Student("Gosho Irigoshev", 12345);
            var studentGenadi = new Student("Genadi Irigoshev", 22345);
            var studentNikodim = new Student("Nikodim Irigoshev", 62345);
            // Act 
            courses.AddStudentToCourse(studentGosho);
            courses.AddStudentToCourse(studentGenadi);
            courses.AddStudentToCourse(studentNikodim);

            courses.RemoveStudentFromCourse(studentGosho);
            courses.RemoveStudentFromCourse(studentGenadi);
            // Assert
            Assert.AreEqual(1, courses.StudentsList.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void RemoveStudentFromCourseMethodShouldThrowArgumentExceptionWhenRemovedStudentsAreMoreThenTheExistingOnesInTheCourse()
        {
            var courses = new Course();
            var studentGosho = new Student("Gosho Irigoshev", 12345);
            var studentNikodim = new Student("Nikodim Irigoshev", 62345);
            var studentNgolo = new Student("Ngolo Kante", 11111);

            courses.AddStudentToCourse(studentGosho);
            courses.RemoveStudentFromCourse(studentNikodim);
            courses.RemoveStudentFromCourse(studentNgolo);
        }
    }
}
