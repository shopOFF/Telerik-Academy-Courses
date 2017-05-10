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
    public class UsernameTests
    {
        [TestCase(null)]
        [TestCase("")]
        [TestCase("1")]
        [TestCase("thisiswaytolongsoitsinvalid!!!!!!!!!!!")]
        [TestCase("              ")]
        public void Username_WhenPassedValueIsInvalid_ShouldThrowArgumentException(string invalidUsername)
        {
            // Arrange, Act & Assert
            Assert.Throws<ArgumentException>(() => new FakeUser(invalidUsername));
        }

        [Test]
        public void Username_WhenPassedValueIsValid_ShouldNotThrow()
        {
            // Arrange  
            var userName = "Geshev";

            // Act
            var user = new FakeUser(userName);

            // Act & Assert
            Assert.AreEqual(userName, user.Username);
        }
    }
}
