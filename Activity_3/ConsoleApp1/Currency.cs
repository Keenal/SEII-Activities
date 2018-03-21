using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity2
{
    
    public abstract class Currency
    {
        private CurrencyType type;
    
        public CurrencyType Type
        {
            get;
            set;
        }

        // Replace the Currency constructor with a factory method for each of the Currency types
        public static Currency USD(CurrencyType type)
        {
            Currency = new Currency(type);
            return Currency;
        }

        public static Currency Pounds(CurrencyType type)
        {
            Currency = new Currency(type);
            return Currency;
        }

        public static Currency Euros(CurrencyType type)
        {
            Currency = new Currency(type);
            return Currency;
        }

        public abstract double ConvertToUSD(double startingAmount, CurrencyType convertedCurrencyType);

        public abstract double ConvertFromUSD(double startingAmount, CurrencyType convertedCurrencyType);

        public virtual double ConvertCurrency(double startingAmount, CurrencyType convertedCurrencyType)
        {
            double finalAmount = 0.0;

            // convert the current from USD to current
            if (this.type == CurrencyType.USD) {
                finalAmount = ConvertFromUSD(startingAmount, this.type);
            }

            if (this.type == CurrencyType.Pounds)
            {
                finalAmount = ConvertFromUSD(0.65 * startingAmount, this.type);
            }

            if (this.type == CurrencyType.Euros)
            {
                finalAmount = ConvertFromUSD(0.88 * startingAmount, this.type);
            }

            // convert the current currency to USD
            if (this.type == CurrencyType.USD) {
                finalAmount = ConvertToUSD(startingAmount, CurrencyType.USD);
            }

            if (this.type == CurrencyType.Pounds)
            {
                finalAmount = ConvertToUSD(1.54 * startingAmount, CurrencyType.USD);
            }

            if (this.type == CurrencyType.Euros)
            {
                finalAmount = ConvertToUSD(1.14 * startingAmount, CurrencyType.USD);
            }

            return finalAmount;
        }

        //formats a currency to two decimal places
        public virtual String formatCurrency(double amount)
        {
            return String.Format("{0:0.00}", amount);
        }   
}

}
