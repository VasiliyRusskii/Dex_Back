using System;
using System.Collections.Generic;
using System.Text;

namespace SemplesForOOP
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual void Displai()
        {
            Console.WriteLine($"Person = {Name}\n Age = {Age}");
        }
    }
}
