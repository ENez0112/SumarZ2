using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sumar.Controllers;

namespace UnitTestSumar
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdd1()
        {
            // Arrange
            SumaController sumaController = new SumaController();
            int a = 5;
            int b = 8;
            int esperado = 13;

            // ACT
            int resultado = sumaController.Add(a, b);

            // Assert
            Assert.AreEqual(esperado, resultado);
        }
        [TestMethod]    
        public void TestAdd2()
        {
            // Arrange
            SumaController sumaController = new SumaController();
            int a = -3;
            int b = -5;
            int esperado = -8;

            // ACT
            int resultado = sumaController.Add(a, b);

            // Assert
            Assert.AreEqual(esperado, resultado);
        }
        [TestMethod]
        public void TestAdd3()
        {
            // Arrange
            SumaController sumaController = new SumaController();
            int a = 3;
            int b = -5;
            int esperado = -2;

            // ACT
            int resultado = sumaController.Add2(a, b);

            // Assert
            Assert.AreEqual(esperado, resultado);
        }
        [TestMethod]
        public void TestAdd4()
        {
            // Arrange
            SumaController sumaController = new SumaController();
            int a = 3;
            int b = 0;
            int esperado = 3;

            // ACT
            int resultado = sumaController.Add2(a, b);

            // Assert
            Assert.AreEqual(esperado, resultado);
        }
        [TestMethod]
        public void TestProduct1()
        {
            // ARRANGE
            MultController multController = new MultController();
            int a = 3;
            int b = 5;
            int esperado = 15;

            // ACT
            int resultado = multController.Product(a, b);

            // Assert
            Assert.AreEqual(esperado, resultado);
        }
        [TestMethod]
        public void TestProduct2()
        {
            // ARRANGE
            MultController multController = new MultController();
            int a = -3;
            int b = -5;
            int esperado = 15;

            // ACT
            int resultado = multController.Product(a, b);

            // Assert
            Assert.AreEqual(esperado, resultado);
        }
        [TestMethod]
        public void TestProduct3()
        {
            // ARRANGE
            MultController multController = new MultController();
            int a = -3;
            int b = 0;
            int esperado = 0;

            // ACT
            int resultado = multController.Product2(a, b);

            // Assert
            Assert.AreEqual(esperado, resultado);
        }
        [TestMethod]
        public void TestProduct4()
        {
            // ARRANGE
            MultController multController = new MultController();
            int a = 0;
            int b = 0;
            int esperado = 0;

            // ACT
            int resultado = multController.Product2(a, b);

            // Assert
            Assert.AreEqual(esperado, resultado);
        }
    }
}
