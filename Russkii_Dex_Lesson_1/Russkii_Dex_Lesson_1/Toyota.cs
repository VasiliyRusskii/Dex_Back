using System;
using System.Collections.Generic;
using System.Text;

namespace Russkii_Dex_Lesson_1
{
    public class Toyota : CarInfo
    {
        public override void Display()
        {
            Console.WriteLine($"Информация Toyota {Name} \n " +
                $"Количество лошадинных сил = {Hourse} \n " +
                $"Максимальная скорость = {MaxSpeed} \n " +
                $"Цена = {Price}");
        }
    }
}
