using Microsoft.VisualStudio.TestTools.UnitTesting;
using Primeiro.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeiro.Model.Tests
{
    [TestClass()]
    public class ContasTests
    {
        [TestMethod()]
        public void SomarTest()
        {
            int a = 10;
            int b = 0;
            int esperado = 10;

            Contas operations = new();
            var resultado = operations.Somar(a,b);

            Assert.AreEqual(esperado,resultado);
        }

        [TestMethod()]
        public void SubstrairTest()
        {
            int a = 10;
            int b = 0;
            int esperado = 10;

            Contas operations = new();
            var resultado = operations.Substrair(a, b);

            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod()]
        public void DividirTest()
        {
            int a = 5;
            int b = 5;
            int esperado = 1;

            Contas operations = new();
            var resultado = operations.Dividir(a, b);

            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod()]
        public void MultiplicarTest()
        {
            int a = 5;
            int b = 5;
            int esperado = 25;

            Contas operations = new();
            var resultado = operations.Multiplicar(a, b);

            Assert.AreEqual(esperado, resultado);
        }
    }
}