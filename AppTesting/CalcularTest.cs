using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using AppNegocio;

namespace AppTesting
{
    [TestClass]
    public class CalcularTest
    {
        [TestMethod]
        public void TestCalcularYExitoso()
        {

            double x = 2;
            double y = 0;
            double esperado = 14;

            Negocio Negocio = new Negocio();

            y = Negocio.CalcularY(x);

            Assert.AreEqual(esperado, y);  
        }

    }
}
