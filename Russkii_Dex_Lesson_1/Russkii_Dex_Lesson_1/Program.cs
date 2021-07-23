using System;

namespace Russkii_Dex_Lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            CarInfo carInfo = new CarInfo() { Name = "Car", Hourse = 999, MaxSpeed = 999, Price = "999$" };
            carInfo.Display();

            Nissan nissan = new Nissan() { Name = "Silva", Hourse = 236, MaxSpeed = 300, Price = "10 000$"};
            nissan.Display();

            Honda honda = new Honda() { Name = "RX-7", Hourse = 198, MaxSpeed = 256, Price = "9 655$" };
            honda.Display();

            Toyota toyota = new Toyota() { Name = "Supra", Hourse = 650, MaxSpeed = 325, Price = "25 000$" };
            toyota.Display();
           
        }
    }
}
