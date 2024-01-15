using NUnit.Framework;

namespace MyMath.Tests
{
    [TestClass]
    public class OperationsTests
    {
        [TestMethod]
        public void Add_ShouldReturnCorrectSum()
        {
            // Arrange
            int a = 5;
            int b = 7;
            
            // Act
            int result = Operations.Add(a, b);
            
            // Assert
            Assert.AreEqual(12, result);
        }
    }
}