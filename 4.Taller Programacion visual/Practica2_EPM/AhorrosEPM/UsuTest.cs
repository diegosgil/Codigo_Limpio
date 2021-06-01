using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AhorroEPM;

namespace AhorrosEPMTest
{
    [TestClass]
    public class UsuTest
    {
        [TestMethod]
        public void TestMethodCalcularValorTotal()
        {
            //Arrange
            int ahorro = 180;
            int consumo = 200;
            int valorEsperado = 110000;
            Usuario total = new Usuario("1017254321", 3, ahorro, consumo);

            //Act
            int valorTotal = total.calcularValorTotal();

            //Assert
            Assert.AreEqual(valorEsperado, valorTotal, "No es posible calcular el valor total");
        }

        [TestMethod]
        public void TestMethodValorTotalDescuento()
        {
            //Arrange
            int valorTotalUsu = 240;
            Usuario totalUsu1 = new Usuario("1017254329", 3, 180, 200, 50, 90);
            Usuario totalUsu2 = new Usuario("1017254328", 3, 180, 200, 80, 40);
            Usuario totalUsu3 = new Usuario("1017254327", 3, 180, 200, 100, 110);

            Form1.listaUsuarios.Add(totalUsu1);
            Form1.listaUsuarios.Add(totalUsu2);
            Form1.listaUsuarios.Add(totalUsu3);

            //Act
            int resultadoDescuento = Form1.valorTotalDesc();

            //Assert
            Assert.AreEqual(valorTotalUsu, resultadoDescuento, "No es posible calcular el valor total descuento");
        }

        [TestMethod]
        public void TestMethodContabilizarClientes()
        {
            //Arrange
            int valorTotalDescuento = 2;    //Se coloca '5' debido a que los dos que se crean aca se suman los usuarios de arriba
            Usuario totalUsu4 = new Usuario("1017254326", 3, 180, 200, 20, 50);
            Usuario totalUsu5 = new Usuario("1017254325", 3, 180, 200, 80, 120);

            Form1.listaUsuarios.Add(totalUsu4);
            Form1.listaUsuarios.Add(totalUsu5);

            //Act
            int resultadoContabilizarClientes = Form1.ContabilizarClientes();

            //Assert
            Assert.AreEqual(valorTotalDescuento, resultadoContabilizarClientes, "No es posible calcular los clientes");
        }
    }
}
