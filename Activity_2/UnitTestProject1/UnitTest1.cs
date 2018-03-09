using System;
using Activity2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApp1 
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestUSDtoPounds()
        {
            // Arrange
            double startingAmount = 100.0;

            var x = new Currency(CurrencyType.USD);
            double expected = 65.0;

            // Act 
            double finalAmount = x.ConvertCurrency(startingAmount, CurrencyType.Pounds);

            // Assert 

            Assert.AreEqual(expected, finalAmount);
        }
        [TestMethod]
        public void TestUSDtoEuros()
        {
            // Arrange
            double startingAmount = 100.0;

            var x = new Currency(CurrencyType.USD);
            double expected = 88.0;

            // Act 
            double finalAmount = x.ConvertCurrency(startingAmount, CurrencyType.Euros);

            // Assert 

            Assert.AreEqual(expected, finalAmount);

        }
        [TestMethod]
        public void TestPoundstoUSD()
        {
            // Arrange
            double startingAmount = 100.0;

            var x = new Currency(CurrencyType.Pounds);
            double expected = 154.0;

            // Act 
            double finalAmount = x.ConvertCurrency(startingAmount, CurrencyType.USD);

            // Assert 

            Assert.AreEqual(expected, finalAmount);

        }
    }
}
