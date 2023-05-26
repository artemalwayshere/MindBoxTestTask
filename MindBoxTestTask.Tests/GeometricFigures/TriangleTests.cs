using MindBoxTestTask.Library.GeometricFigures;

namespace MindBoxTestTask.Tests.GeometricFigures
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void GetSquare_CorrectSides_CorrectSquare()
        {
            // Arrange
            const int sideA = 3;
            const int sideB = 4;
            const int sideC = 5;
            var triangle = new Triangle(sideA, sideB, sideC);

            // Act
            var result = triangle.GetSquare();

            // Assert
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        [DataRow(1, 2, 3)]
        [DataRow(-1, 2, 3)]
        [DataRow(1, 0, 1)]
        [DataRow(1, 3, -5)]
        public void Ctor_WrongSides_Exception(int sideA, int sideB, int sideC)
        {
            // Act
            // Assert
            Assert.ThrowsException<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
        }

        [TestMethod]
        public void IsRightTriangle()
        {
            // Arrange
            const int sideA = 3;
            const int sideB = 4;
            const int sideC = 5;
            var triangle = new Triangle(sideA, sideB, sideC);

            // Act
            var result = triangle.IsRightTriangle();

            // Assert
            Assert.IsTrue(result);
        }
    }
}
