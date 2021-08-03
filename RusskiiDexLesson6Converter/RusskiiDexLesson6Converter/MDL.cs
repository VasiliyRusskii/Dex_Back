using System;
using System.Collections.Generic;
using System.Text;

namespace RusskiiDexLesson6Converter
{
    class MDL : Currency
    {
        public override double Rate { get; set; } = 17.9;

        public override string CurrencyPrefix { get; set; } = "MDL";
    }
}
