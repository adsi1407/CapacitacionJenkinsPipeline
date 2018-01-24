using Microsoft.VisualStudio.TestTools.UnitTesting;
using Caculadora;

namespace Calculadora.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int expected = 6;

            //Act
            var calculadora = new Add();
            var result = calculadora.AddNumbers(2, 4);

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
