using System;

namespace DexLesson4IEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] peopleArray = new Person[3]
            {
            new Person("John Ivanov Russkii", "IP-4003", "300$"),
            new Person("Oleg Petrovich Derykors", "IP-7018", "5000$"),
            new Person("Dmitry Olegovich Polskii", "IP-7803", "900$"),
            };

            People peopleList = new People(peopleArray);
            foreach (Person p in peopleList)
                Console.WriteLine(p.firstName + " " + p.lastName);
        }
    }
    }
}
