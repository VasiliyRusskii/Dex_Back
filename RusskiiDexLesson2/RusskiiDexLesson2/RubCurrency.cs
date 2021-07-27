using System;
using System.Collections.Generic;
using System.Text;

namespace RusskiiDexLesson2
{
    public  class RubCurrency : Currency
    {
        public static double rate { get; set; }

        public RubCurrency()
        {
            rate = 16.3;
        }

    }
}
