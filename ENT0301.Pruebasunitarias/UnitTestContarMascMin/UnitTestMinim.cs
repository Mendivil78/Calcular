using Microsoft.VisualStudio.TestTools.UnitTesting;
using ENT0301.Pruebasunitarias;
using System;

namespace UnitTestContarMascMin
{
    [TestClass]
    public class UnitTestMininusculas
    {
        [TestMethod]
        [DataRow("La PRueba DE Los Minimos", 13)]
        [DataRow(" ",0)]
        public void TestMethodMinuscula(string cadena1, int esperado)
        {
            //Act
            int vecesmin = Funciones.ContarMinusculas(cadena1);
            //Assert
            Assert.AreEqual(vecesmin, esperado);
        }
    }
}
