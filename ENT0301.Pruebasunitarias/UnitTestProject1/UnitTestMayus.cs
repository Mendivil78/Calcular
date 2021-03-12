using Microsoft.VisualStudio.TestTools.UnitTesting;
using ENT0301.Pruebasunitarias;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestMayus
    {
        [TestMethod]
        [DataRow("La primerA PRueba DE Los MaXimos", 9)]
        [DataRow(" ", 0)]
        public void TestMhetodMayusculas(string cadena1, int esperado)
        {
            //Act
            int vecesmay = Funciones.ContarMayusculas(cadena1);
            //Assert
            Assert.AreEqual(vecesmay, esperado);
        }
    }
}
