using System;
using System.Collections.Generic;
using System.Text;

namespace RusskiiDexLesson2
{
    public class MDLCurrency : Currency
    {
        public static double rate { get; set; }

        public MDLCurrency()
        {
            rate = 0.05;
        }
    }
}
