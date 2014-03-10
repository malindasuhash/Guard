using NUnit.Framework;
using XGuard.Exceptions;

namespace XGuard.Test
{
    [TestFixture]
    public class WhenNullTest
    {
        [Test]
        public void ThrowIfNull_WhenGivenInstanceIsNull_ThrowsException()
        {
            // Arrange
            object instance = null;

            // Act / Assert
            Assert.Throws<ItemNullException>(() => { x.ThrowIfNull(instance); });
        }

        [Test]
        public void ThrowIfNull_WhenGivenInstanceIsNull_ThrowsExceptionWithMessage()
        {
            // Arrange
            object instance = null;
            var expectedMsg = "The instance is null.";

            // Act / Assert
            Assert.Throws<ItemNullException>(() => { x.ThrowIfNull(instance, expectedMsg); }, expectedMsg);
        }

        [Test]
        public void ThrowIfNull_WhenUsedMessageIsNull_ThrowsException()
        {
            // Arrange
            string usedMessage = null;

            // Act / Assert
            Assert.Throws<ItemNullException>(() => x.ThrowIfNull(new object(), usedMessage));
        }

        [Test]
        public void ThrowIfNull_WhenGivenInstanceIsNull_ThrowsExceptionOfGivenType()
        {
            // Arrange
            object instance = null;

            // Act / Assert
            Assert.Throws<TestException>(() => { x.ThrowIfNull<TestException>(instance); });
        }

        [Test]
        public void ThrowIfNull_WhenGivenInstanceIsNotNull_DoesNotThrowException()
        {
            // Arrange / Act
            x.ThrowIfNull(new object());
            x.ThrowIfNull(new object(), "message");
            x.ThrowIfNull<TestException>("some value");

            Assert.Pass();
        }

        [Test]
        public void IsNull_WhenItemIsNull_ReturnsTrue()
        {
            // Act
            bool result = x.IsNull(null);

            // Assert
            Assert.True(result);
        }
    }
}