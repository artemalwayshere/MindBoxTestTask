using MindBoxTestTask.Library.GeometricFigures;

namespace MindBoxTestTask.Tests.GeometricFigures
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void GetSquare_CorrectAsExpected()
        {
            // Arrange
            const int radius = 2;
            var circle = new Circle(radius);

            // Act
            var result = circle.GetSquare();
            var expected = Math.Pow(radius, 2) * Math.PI;

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(0)]
        [DataRow(-13)]
        public void Ctor_WrongSides_Exception(int radius)
        {
            // Act
            // Assert
            Assert.ThrowsException<ArgumentException>(() => new Circle(radius));
        }
    }
}
