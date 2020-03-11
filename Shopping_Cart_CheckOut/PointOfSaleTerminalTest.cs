using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shopping_Cart_CheckOut.Library;
using Shopping_Cart_CheckOut.Library.Model;
using System;
using System.Collections.Generic;

namespace Shopping_Cart_CheckOut
{
    [TestClass]
    public class PointOfSaleTerminalTest
    {
        private readonly PointOfSaleTerminal posTerm = new PointOfSaleTerminal();
        private readonly PriceCalculator pCalc = new PriceCalculator();
        private IList<Product> _finalProduct = null;
        private decimal totalPrice = 0;

        [TestMethod]
        public void CCCCCCC_Is_6()
        {
            _finalProduct = posTerm.ScanProduct("CCCCCCC");
            totalPrice = pCalc.CalculateTotalPrice(_finalProduct);

            Assert.AreEqual(6, totalPrice);
        }

        [TestMethod]
        public void ABCDABA_Is_13_25()
        {
            _finalProduct = posTerm.ScanProduct("ABCDABA");
            totalPrice = pCalc.CalculateTotalPrice(_finalProduct);

            Assert.AreEqual(Convert.ToDecimal(13.25), totalPrice);
        }

        [TestMethod]
        public void ABCD_Is_7_25()
        {
            _finalProduct = posTerm.ScanProduct("ABCD");
            totalPrice = pCalc.CalculateTotalPrice(_finalProduct);

            Assert.AreEqual(Convert.ToDecimal(7.25), totalPrice);
        }


        //Extra Test Cases
        [TestMethod]
        public void NoProducts_Price_Is_0()
        {
            _finalProduct = posTerm.ScanProduct("");
            totalPrice = pCalc.CalculateTotalPrice(_finalProduct);

            Assert.AreEqual(0, totalPrice);
        }

        [TestMethod]
        public void OneA_Is_1_25()
        {
            _finalProduct = posTerm.ScanProduct("A");
            totalPrice = pCalc.CalculateTotalPrice(_finalProduct);

            Assert.AreEqual(Convert.ToDecimal(1.25), totalPrice);
        }

        [TestMethod]
        public void ThreeA_Is_3()
        {
            _finalProduct = posTerm.ScanProduct("AAA");
            totalPrice = pCalc.CalculateTotalPrice(_finalProduct);

            Assert.AreEqual(3, totalPrice);
        }

        [TestMethod]
        public void OneB_Is_4_25()
        {
            _finalProduct = posTerm.ScanProduct("B");
            totalPrice = pCalc.CalculateTotalPrice(_finalProduct);

            Assert.AreEqual(Convert.ToDecimal(4.25), totalPrice);
        }

        [TestMethod]
        public void OneC_Is_1()
        {
            _finalProduct = posTerm.ScanProduct("C");
            totalPrice = pCalc.CalculateTotalPrice(_finalProduct);

            Assert.AreEqual(1, totalPrice);
        }

        [TestMethod]
        public void SixC_Is_5()
        {
            _finalProduct = posTerm.ScanProduct("CCCCCC");
            totalPrice = pCalc.CalculateTotalPrice(_finalProduct);

            Assert.AreEqual(5, totalPrice);
        }

        [TestMethod]
        public void OneD_Is_0_75()
        {
            _finalProduct = posTerm.ScanProduct("D");
            totalPrice = pCalc.CalculateTotalPrice(_finalProduct);

            Assert.AreEqual(Convert.ToDecimal(0.75), totalPrice);
        }

        [TestMethod]
        public void OutProduct_Is_0()
        {
            _finalProduct = posTerm.ScanProduct("E");
            totalPrice = pCalc.CalculateTotalPrice(_finalProduct);

            Assert.AreEqual(Convert.ToDecimal(0), totalPrice);
        }
    }
}
