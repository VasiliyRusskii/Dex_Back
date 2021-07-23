using System;
using System.Collections.Generic;
using System.Text;

namespace Russkii_Dex_Lesson_1
{
    public class CarInfo
    {
        public string Name { get; set; }
        public int Hourse { get; set; }
        public int MaxSpeed { get; set; }
        public string Price { get; set; }

        public virtual void Display()
        {
            Console.WriteLine($"Тестовая информация \n {Name} \n {Hourse}\n {MaxSpeed}\n {Price}");
        }
    }
}
