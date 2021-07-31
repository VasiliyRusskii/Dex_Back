using System;

namespace DexLesson4Equals
{
    public class Money
    {
        public decimal Amount { get; set; }
        public string Unit { get; set; }

        public Money(decimal amount, string unit)
        {
            Amount = amount;
            Unit = unit;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            //Рассмотрим оператор равенства "=="
            string namePersonCompany = "Tesla";
            string namePersonSchool = "Tiraspol";
            string variousName = namePersonCompany;
            Console.WriteLine(namePersonCompany == namePersonSchool); // false
            Console.WriteLine(namePersonCompany == variousName); // true

            //Equals и GetHashCode
            Person personOne = new Person("Ivan Olegovich Naumov", "03.06.2021", "PMR", "IP-40003" );
            Person personTwo = new Person("Ivan Olegovich Naumov", "03.06.2021", "PMR", "IP-40003");
            Person personThree = new Person("Oleg Olegovich Naumov", "03.09.2021", "Russian", "IP-40004");
            Console.WriteLine(personOne.GetHashCode()); // 101
            Console.WriteLine(personTwo.GetHashCode()); // 101
            Console.WriteLine(personThree.GetHashCode()); // 102
            Console.ReadLine();
        }
    }
}
