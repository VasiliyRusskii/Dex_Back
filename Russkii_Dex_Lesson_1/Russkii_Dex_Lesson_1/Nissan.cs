using System;
using System.Collections.Generic;
using System.Text;

namespace Russkii_Dex_Lesson_1
{
    public class Nissan : CarInfo
    {
        public override void Display()
        {
            Console.WriteLine($"Информация Nissan {Name} \n " +
                $"Количество лошадинных сил = {Hourse} \n " +
                $"Максимальная скорость = {MaxSpeed} \n " +
                $"Цена = {Price}");
        }
    }
}
