using System;
using System.Collections.Generic;
using System.Text;

namespace TaskPerson
{
    class Person
    {
        //Fields
        public string Name;
       private int _age;

        //Constructor
        public Person()
        {
            Name = "unknown";
            _age = 0;
        }
        public Person (string name, int age)
        {
            Name = name;
            _age = age;
        }
        //Methods
        public void GrowOld()
        {
            this._age++;

        }
        public void GrowOld(int number)
        {
            this._age = this._age + number;
        }
        public void PrintPersonInfo()
        {
            Console.WriteLine($"Nimi:{Name}");
            Console.WriteLine($"Ikä: {_age}");
            Console.WriteLine($"Aikuinen: {IsAdult()}");
            
        }

        public bool IsAdult()
        {
           // return this._age >= 18; <------------vaihtoehtoisesti näin
            if (this._age >= 18)
                return true;
            else
            return false;
        }

        public int GetAge()
        {
            return this._age;
        }
    
   
            
    }
}
