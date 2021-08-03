using System;
using System.Collections.Generic;
using System.Text;

namespace RusskiiDexLesson6Converter
{
    class Account
    {
        public Currency CurrencyType { get; set; }
        public double MoneyAmount { get; set; }
        public Currency CurrencyTypeFirst { get; set; }
        public double MoneyAmountFirst { get; set; }
        public Currency CurrencyTypeSecond { get; set; }
        public double MoneyAmountSecond { get; set; }

        public Account(Currency currencyTypeFirst, double moneyAmountFirst, Currency currencyTypeSecond, double moneyAmountSecond) : this(currencyTypeFirst, moneyAmountFirst)
        {
            CurrencyTypeSecond = currencyTypeSecond;
            MoneyAmountSecond = moneyAmountSecond;
        }

        public Account(Currency currencyTypeFirst, double moneyAmountFirst)
        {
            CurrencyTypeFirst = currencyTypeFirst;
            MoneyAmountFirst = moneyAmountFirst;
        }

        public double CalculateInDollars()
        {
            if (MoneyAmountSecond != 0)
                return MoneyAmountSecond / CurrencyTypeSecond.Rate;

            return MoneyAmountFirst / CurrencyTypeFirst.Rate;
        }
    }
}
