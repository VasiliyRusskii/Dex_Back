using System;
using System.Collections.Generic;
using System.Text;

namespace DexLesson4IEnumerable
{
    class Person 
    {
        public string lastFirstMiddleName { get; set; }
        public string numberPassport { get; set; }
        public string amountOnTheAccount { get; set; }

        public Person(string lastFirstMiddleName, string numberPassport, string amountOnTheAccount)
        {
            this.lastFirstMiddleName = lastFirstMiddleName;
            this.numberPassport = numberPassport;
            this.amountOnTheAccount = amountOnTheAccount;
        }
    }
}
