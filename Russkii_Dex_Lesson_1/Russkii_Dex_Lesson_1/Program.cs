using System;

namespace Russkii_Dex_Lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            CarInfo carInfo = new CarInfo() { Hourse = 999, MaxSpeed = 999, Price = "999$" };
            carInfo.Display();

            Nissan nissan = new Nissan() { Hourse = 236, MaxSpeed = 300, Price = "10 000$"};
            nissan.Display();

            Honda honda = new Honda() { Hourse = 198, MaxSpeed = 256, Price = "9 655$" };
            honda.Display();
           
        }
    }
}
