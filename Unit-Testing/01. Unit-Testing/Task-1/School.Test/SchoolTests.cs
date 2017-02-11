namespace School.Test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Collections.Generic;

    [TestClass]
    public class SchoolTests
    {
        [TestMethod]
        public void TestSchoolCtor()
        {
            var studentMark= new Student("Mark Markov", 11111);
            var studentPeter = new Student("Peter Sagan", 12111);
            var studentBastian = new Student("Bastian Schweinsteiger", 11122);
            var studentJose = new Student("Jose Mourinho", 41111); ;

            var studentsSet = new List<Student> { studentMark, studentPeter, studentBastian, studentJose };
            var studentsSet2 = new List<Student> { studentMark, studentPeter };
            var studentsSet3 = new List<Student> { studentJose };
            var studentsSet4 = new List<Student> { studentJose, studentBastian };

            var course = new Course();
            course.AddStudentToCourse(studentPeter);
            course.AddStudentToCourse(studentMark);
            var course2 = new Course();
            course2.AddStudentToCourse(studentBastian);
            var course3 = new Course();
            course3.AddStudentToCourse(studentPeter);
            course3.AddStudentToCourse(studentJose);
            course3.AddStudentToCourse(studentBastian);
            course3.AddStudentToCourse(studentMark);

            
            var courseSet = new List<Course> { course, course2, course3};
            var newSchool = new School(studentsSet, courseSet);

            Assert.AreEqual(studentsSet.Count, newSchool.Students.Count);
            Assert.AreEqual(courseSet.Count, newSchool.Courses.Count);
        }
    }
}
