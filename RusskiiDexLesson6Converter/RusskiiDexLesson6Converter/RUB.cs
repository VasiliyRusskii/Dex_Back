using System;
using System.Collections.Generic;
using System.Text;

namespace RusskiiDexLesson6Converter
{
    class RUB : Currency
    {
        public override double Rate { get; set; } = 72;
        public override string CurrencyPrefix { get; set; } = "RUB";
    }
}
