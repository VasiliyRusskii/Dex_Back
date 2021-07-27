using System;

namespace RusskiiDexLesson2
{
    class Program
    {
        public static RubCurrency rub = new RubCurrency();
        public static UAHCurrency uah = new UAHCurrency();
        public static MDLCurrency mdl = new MDLCurrency();

        static void Main(string[] args)
        {
            double amount = 100;
            Console.WriteLine("RUB => MDL : " + Convert(rub, mdl, amount)
                + "\nMDL => UAH : " + Convert(mdl, uah, amount)
                + "\nUAH => RUB : " + Convert(uah, rub, amount));

            Console.ReadKey();
        }

        static public double Convert(Currency originCurrency, Currency finalCurrency, double amount)
        {
            if (originCurrency is RubCurrency)
            {
                return (amount / RubCurrency.rate) * ((finalCurrency is MDLCurrency) ? MDLCurrency.rate : UAHCurrency.rate);
            }
            if (originCurrency is UAHCurrency)
            {
                return (amount / UAHCurrency.rate) * ((finalCurrency is MDLCurrency) ? MDLCurrency.rate : RubCurrency.rate);
            }
            return (amount / MDLCurrency.rate) * ((finalCurrency is UAHCurrency) ? UAHCurrency.rate : RubCurrency.rate);
        }
    }
}
