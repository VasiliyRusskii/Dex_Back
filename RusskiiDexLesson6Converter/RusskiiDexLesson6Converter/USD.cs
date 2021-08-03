using System;
using System.Collections.Generic;
using System.Text;

namespace RusskiiDexLesson6Converter
{
    class USD : Currency
    {
        public override double Rate { get; set; } = 1;
        public override string CurrencyPrefix { get; set; } = "$";
    }
}
