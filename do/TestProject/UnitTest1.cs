using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UnitTest1;

namespace TestProject
{

    /*
     AAA

    Arrange => Inicializamos variables
    Act => Llamamos el metodo a testear
    Assert => verificamos resultado

     */

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ATestSuma()
        {
            //Arrange
            var operador1 = 10; //set manual (pero esto tambien se puede automatizar)
            var operador2 = 11;

            //Act
            //se instancia en muchas de las ocasiones los metodos del negocio (dll)
            var result = ProcesadorMatematico.Sumar(operador1, operador2);

            //Assert
            var ValorEsperado = 21;

            Assert.AreEqual(ValorEsperado, result);

        }

        [TestMethod]
        public void BTestSumaPositivaConError()
        {
            //Arrange
            var operador1 = 10; //set manual (pero esto tambien se puede automatizar)
            var operador2 = 20;

            //Act
            //se instancia en muchas de las ocasiones los metodos del negocio (dll)
            var result = ProcesadorMatematico.Sumar(operador1, operador2);


            //Assert
            bool positivo = false;

            if(result > 0)
            {
                positivo = true;
            }

            Assert.IsTrue(positivo);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DTestDivisionExcepcion()
        {
            //Arrange
            var dividendo = 10;
            var divisor = 0;

            //Act
            var result = ProcesadorMatematico.Division(dividendo, divisor);

            //Assert
            //En este caso, no deberiamos llegar aqui, la prueba correcta es una excepci�n de DivisionEntreCero

        }
    }
}