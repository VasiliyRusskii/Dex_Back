using System;
using System.Collections.Generic;
using System.Text;

namespace RusskiiDexLesson2
{
    public class UAHCurrency : Currency
    {
        public static double rate { get; set; }

        public UAHCurrency()
        {
            rate = 0.04;
        }

    }
}
