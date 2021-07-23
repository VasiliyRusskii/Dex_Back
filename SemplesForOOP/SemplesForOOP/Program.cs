using System;

namespace SemplesForOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person() { Name = "Olga", Age = 22};
            person.Displai();

            Friend friend = new Friend() { Name = "Alex", Age = 18 };
            friend.Displai();

            Coleague coleague = new Coleague() { Name = "Ivan", Age = 24 };
            coleague.Displai();

            Person[] people = new Person[] { person, friend, coleague };

            foreach (var item in people)
            {
                item.Displai();
            }

            Console.ReadKey();
        }
    }
}
