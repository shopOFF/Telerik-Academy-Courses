namespace School.Test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class StudentTests
    {
        private const int UniqueStudentNumberMinValue = 10000;
        private const int UniqueStudentNumberMaxValue = 99999;


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void StudentsNameShouldThrowArgumentExceptionWhenNullIsPassedToIt()
        {
            var studentTest = new Student(null, UniqueStudentNumberMinValue);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void StudentsNameShouldThrowArgumentExceptionIfItsEmpty()
        {
            var studentTest = new Student(string.Empty, UniqueStudentNumberMinValue);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void UniqueStudentNumberShouldThrowArgumentOutOfRangeExceptionIfIsNotBetween10000And99999()
        {
            var studentTest = new Student("Pesho Peshev", 111191);
        }
    }
}
