using System;
using Activity2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestCurrencyService()
        {
            double amount = 100.0;
            var currency = new Currency(CurrencyType.USD);
           // Currency startingType = CurrencyType.USD;
          //  Currency endingType = CurrencyType.Euros;
            var mockRepository = new Mock<ICurrencyRepository>();

            mockRepository.Setup(r => r.getCurrency(CurrencyType.USD)).Returns(currency);
            var sut = new CurrencyService(mockRepository.Object);


            double actual = sut.convertCurrency(amount, CurrencyType.USD, CurrencyType.Euros);
            double expected = 88.0;
            Assert.AreEqual(expected, actual);
        }
    }
}
