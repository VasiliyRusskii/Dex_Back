using System;
using System.Collections.Generic;
using System.Text;

namespace DexLesson4Equals
{
    public class Person
    {
        public string lastFirstMiddleName { get; set; }
        public string birthDay { get; set; }
        public string placeOfBirth { get; set; }
        public string numberPassword { get; set; }

        public Person(string lastFirstMiddleNamePerson, string birthDayPerson, string placeOfBirthPerson, string numberPasswordPerson)
        {
            lastFirstMiddleName = lastFirstMiddleNamePerson;
            birthDay = birthDayPerson;
            placeOfBirth = placeOfBirthPerson;
            numberPassword = numberPasswordPerson;
        }


        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            Person person = obj as Person;
            if (person as Person == null)
                return false;
            return person.lastFirstMiddleName == this.lastFirstMiddleName && person.birthDay == this.birthDay 
                && person.placeOfBirth == this.placeOfBirth && numberPassword == this.numberPassword;
        }
        public bool Equals(Person obj) 
        {
            if (obj == null)
                return false;
            return obj.lastFirstMiddleName == this.lastFirstMiddleName && obj.birthDay == this.birthDay &&
                obj.placeOfBirth == this.placeOfBirth && obj.numberPassword == this.numberPassword;
        }
        public override int GetHashCode()
        {
            int lastFirstMiddleNameGet;

            if (lastFirstMiddleName == "Ivan Olegovich Naumov")
            {
                return lastFirstMiddleNameGet = 101;
            }
            else
            {
                return lastFirstMiddleNameGet = 102;
            }
            
        }

    }
}
