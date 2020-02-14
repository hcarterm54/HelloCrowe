using NUnit.Framework;

namespace HelloCrowe.Service.Test
{
    public class MessageServiceShould
    {
        [Test]
        public void InMemoryMessageServiceShouldReturnHelloWorld()
        {
            // Arrange
            var sut = new InMemoryMessageService();
            string expected = "Hello World";

            // Act
            var actual = sut.GetMessage();

            // Assert
            Assert.That(expected, Is.EqualTo(actual));
        }


        /// <summary>
        /// This unit test fails since there is no implementation of this service
        /// yet.
        /// TODO: Implement Console message service until this test passes.
        /// </summary>
        [Test]
        public void ConsoleMessageServiceShouldReturnHelloWorld()
        {
            // Arrange
            var sut = new ConsoleMessageService();
            string expected = "Hello World";

            // Act
            var actual = sut.GetMessage();

            // Assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        /// <summary>
        /// This unit test fails since there is no implementation of this service
        /// yet.
        /// TODO: Implement Mobile message service until this test passes.
        /// </summary>
        [Test]
        public void MobileMessageServiceShouldReturnHelloWorld()
        {
            // Arrange
            var sut = new MobileMessageService();
            string expected = "Hello World";

            // Act
            var actual = sut.GetMessage();

            // Assert
            Assert.That(expected, Is.EqualTo(actual));
        }
    }
}
