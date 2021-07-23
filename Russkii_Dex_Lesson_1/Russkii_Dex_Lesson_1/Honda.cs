using System;
using System.Collections.Generic;
using System.Text;

namespace Russkii_Dex_Lesson_1
{
    public class Honda : CarInfo
    {
        public override void Display()
        {
            Console.WriteLine($"Информация Honda \n " +
                $"Количество лошадинных сил = {Hourse} \n " +
                $"Максимальная скорость = {MaxSpeed} \n " +
                $"Цена = {Price}");
        }
    }
}
