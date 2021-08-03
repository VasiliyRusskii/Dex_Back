using System;
using System.Collections.Generic;
using System.Text;

namespace RusskiiDexLesson6Converter
{
    class Client
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Client result = (Client)obj;
            return result.Id == Id;
        }

        public override int GetHashCode()
        {
            return Id;
        }


    }
}
