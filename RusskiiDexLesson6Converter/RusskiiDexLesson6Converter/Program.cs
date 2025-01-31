﻿using System;
using System.Collections.Generic;

namespace RusskiiDexLesson6Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            var userData = new Dictionary<Client, Account>() {

                { new Client() { Name = "Ivan", Id = 1}, new Account( currencyTypeFirst: new MDL(), moneyAmountFirst: 1000,  currencyTypeSecond: new RUB(), moneyAmountSecond: 965)},
                { new Client() { Name = "Alex", Id = 2}, new Account( currencyTypeFirst: new RUB(), moneyAmountFirst: 465, currencyTypeSecond: new MDL(), moneyAmountSecond: 785 )},
                { new Client() { Name = "Dmitry", Id = 3}, new Account( currencyTypeFirst: new RUB(), moneyAmountFirst: 657 )},
                { new Client() { Name = "Oleg", Id = 4}, new Account( currencyTypeFirst: new MDL(), moneyAmountFirst: 596 )}
            };

            foreach (var item in userData)
            {
                string UserName = item.Key.Name;
                int UserId = item.Key.Id;
                double moneyAmountFirst = item.Value.MoneyAmountFirst;
                double moneyAmountSecond = item.Value.MoneyAmountSecond;
                string moneyPrefixFirst = item.Value.CurrencyTypeFirst.CurrencyPrefix;
                string moneyPrefixSecond = null;
                double moneyInDollarsFirst = item.Value.CalculateInDollarsFirst();
                double moneyInDollarsSecond = item.Value.CalculateInDollarsSecond();

                if (item.Value.CurrencyTypeSecond == null)
                {
                    moneyPrefixSecond = null;
                }
                else
                {
                    moneyPrefixSecond = item.Value.CurrencyTypeSecond.CurrencyPrefix;
                }

                if (moneyPrefixSecond != null)
                {
                    Console.WriteLine($"{UserName} ({UserId}) - {moneyAmountFirst} {moneyPrefixFirst} ({moneyInDollarsFirst } $) " +
                        $"{moneyAmountSecond} {moneyPrefixSecond}  ({moneyInDollarsSecond } $)");
                }
                else
                    Console.WriteLine($"{UserName} ({UserId}) - {moneyAmountFirst} {moneyPrefixFirst} ({moneyInDollarsFirst } $)");


            }
            Console.ReadKey();
        }

        
    }
    
}
