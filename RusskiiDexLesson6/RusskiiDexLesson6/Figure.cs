using System;
using System.Collections.Generic;
using System.Text;

namespace RusskiiDexLesson6
{
    class Figure
    {
        public int SideCount { get; set; }
        public int SideLenght { get; set; }

        public Figure(int sideCount, int sideLenght)
        {
            SideCount = sideCount;
            SideLenght = sideLenght;
        }

        public void Display()
        {
            Console.WriteLine($"\nКоличество сторон: {SideCount}\nДлина стороны: {SideLenght}\n");
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (!(obj is Figure))
                return false;
            var result = (Figure)obj;
            return result.SideCount == SideCount && result.SideLenght == SideLenght;
        }

        public override int GetHashCode()
        {
            return SideCount + SideLenght;
        }
    }
}
