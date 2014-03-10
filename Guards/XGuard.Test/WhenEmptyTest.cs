using NUnit.Framework;
using XGuard.Exceptions;

namespace XGuard.Test
{
    [TestFixture]
    public class WhenEmptyTest
    {
        [Test]
        public void ThrowIfEmpty_WhenGivenInstanceIsNull_ThenThrowsException()
        {
            // Act, Assert
            Assert.Throws<ItemNullException>(() => x.ThrowIfEmpty(null));
        }

        [Test]
        public void ThrowIfEmpty_WhenGivenInstanceIsEmpty_ThenThrowsException()
        {
            // Act, Assert
            Assert.Throws<ItemEmptyException>(() => x.ThrowIfEmpty(""));
        }

        [Test]
        public void ThrowIfEmpty_WhenGivenInstanceIsNotEmpty_ThenShouldNotThrowException()
        {
            // Act
            x.ThrowIfEmpty("value");

            Assert.Pass();
        }

        [TestCase("Value", null)]
        [TestCase(null, "message")]
        public void ThrowIfEmpty_WhenGivenInstanceIsEmptyAndWhenMessageIsEmpty_ThrowsException(string value, string msg)
        {
            // Act, Assert
            Assert.Throws<ItemNullException>(() => x.ThrowIfEmpty(value, msg));
        }

        [Test]
        public void ThrowIfEmpty_WhenGivenInstanceEmpty_ThrowsException()
        {
            // Act
            Assert.Throws<ItemEmptyException>(() => x.ThrowIfEmpty("", "message"));
        }

        [Test]
        public void ThrowIfEmpty_WhenGivenInstanceNotEmpty_ThenNoExceptionIsThrown()
        {
            // Act
            x.ThrowIfEmpty("value", "message");

            // Assert
            Assert.Pass();
        }

        [Test]
        public void ThrowIfEmpty_WhenGivenInstanceIsEmpty_GivenExceptionIsThrown()
        {
            // Act, Assert
            Assert.Throws<TestException>(() => x.ThrowIfEmpty<TestException>("")); 
        }

        [TestCase(null)]
        [TestCase("not empty")]
        public void IsEmpty_WhenGivenInstanceIsNotEmptyOrNull_ReturnsFalse(string instance)
        {
            // Act
            bool result = x.IsEmptySpace(instance);

            // Assert
            Assert.False(result);
        }
    }
}