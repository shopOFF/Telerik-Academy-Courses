using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Academy.Models;
using Academy.Core.Providers;
using Moq;
using Academy.Models.Contracts;

namespace Academy.Tests.ModelsTests.CourseTests
{
    [TestFixture]
    public class ToStringTests
    {
        [Test]
        public void ToString_ShouldReturnPassedDataAListOfLectures()
        {
            // Arrange
            var startDate = new DateTime(2017, 7, 7);
            var endDate = new DateTime(2017, 7, 27);
            var courseName = "Math";
            var numberOfLectures = 3;
            var course = new Course(courseName, numberOfLectures, startDate, endDate);
            var fakeTrainer = new Mock<ITrainer>();
            var lecture = new Lecture("Intro", startDate, fakeTrainer.Object);
            var secondLecture = new Lecture("NextStep", startDate, fakeTrainer.Object);

            // Act 
            course.Lectures.Add(lecture);
            course.Lectures.Add(secondLecture);
            var result = course.ToString();

            // Assert
            StringAssert.Contains("NextStep", result);
        }

        [Test]
        public void ToString_ShouldReturnPassedDataAndAMessageSayingThereAreNoLecturesInTheCourse()
        {
            // Arrange
            var startDate = new DateTime(2017, 7, 7);
            var endDate = new DateTime(2017, 7, 27);
            var courseName = "Math";
            var numberOfLectures = 3;
            var course = new Course(courseName, numberOfLectures, startDate, endDate);

            // Act 
            var result = course.ToString();

            // Assert
            StringAssert.Contains("no lectures in this course", result);
        }

        // С ВЕРИФАЙВАНЕ НА МОКНАТ ОБЕКТ!!!!
        [Test]
        public void ToString_ShouldReturnPassedDataAListOfLecturesVerifiMockeObj()
        {
            // Arrange
            var startDate = new DateTime(2017, 7, 7);
            var endDate = new DateTime(2017, 7, 27);
            var courseName = "Math";
            var numberOfLectures = 3;
            var course = new Course(courseName, numberOfLectures, startDate, endDate);

            var fakeLecture = new Mock<ILecture>();
            fakeLecture.Setup(x => x.ToString());  // трябва да сетъпнем метода, който ще верифайваме, иначе няма да работи, така работи Moq
                                    // това със SETUP-a е мн мн важно!!!!


            course.Lectures.Add(fakeLecture.Object);    // добаявяме си мокнатия обект, който ще верифайваме и вече сме готови да викаме метода
            // Act 
            course.ToString();  // 1 ви път викаме метода
            course.ToString();  // 2- ри път викаме метода и тн... 
            course.ToString();  // 3- ри път викаме метода и тн... трябва да верифайнем 

            // Assert
            fakeLecture.Verify(x => x.ToString(), Times.Exactly(3));
        }
    }
}
