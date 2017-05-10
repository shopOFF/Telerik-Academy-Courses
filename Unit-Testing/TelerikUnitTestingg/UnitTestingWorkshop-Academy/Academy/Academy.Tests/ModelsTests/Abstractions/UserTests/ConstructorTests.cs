using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Academy.Models;
using Academy.Models.Enums;
using Academy.Models.Abstractions;
using Academy.Tests.Fakes;

namespace Academy.Tests.ModelsTests.Abstractions.UserTests
{
    [TestFixture]
   public class ConstructorTests
    {
        [Test]
        public void Constructor_ShouldCorrectlyAssignPassedValues()
        {
            // Arrange & Act 
            var userName = "Geshev";
            var user = new FakeUser(userName);

            // Assert
            Assert.AreEqual(userName, user.Username);
        }
    }
}
