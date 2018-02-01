using System;
using System.Collections.Generic;
using System.Text;

namespace lipunhinta
{
    class Customer
    { //Fields
        public string Name;
        public int Age;
        public bool Soldier;
        public bool Student;
        public bool MtkMember;

        //Construction
        public Customer()
        {
            Name = null;
            Age = 0;
            Soldier = false;
            Student = false;
            MtkMember = false;
        }

        public Customer(string name, int age, bool soldier, bool student, bool mtkMember)
        {
            Name = name;
            Age = age;
            Soldier = soldier;
            Student = student;
            MtkMember = mtkMember;
        }

        //Methods
        public void TicketPrice()
        {
            double price = 16.00;

            if (Age < 7)
            {
                price = price - (price * 1);
            }
            else if (Age >= 65)
            {
                price = price - (price * 0.5);
            }
            else if (Age >= 7 && Age <= 15)
            {
                price = price - (price * 0.5);
            }
            else
            {
                if (Soldier == true)
                {
                    price = price - (price * 0.5);
                }
                else if (Student == true)
                {
                    price = price - (price * 0.45);
                }
            }
            Console.WriteLine($"Nimi:{Name}");
            Console.WriteLine($"Ikä:{Age}");
           Console.WriteLine($"varusmies {Soldier}");
            Console.WriteLine($"mtk jäsen? {MtkMember}");
            Console.WriteLine($"lipun hinta on {price} euroa");


        }
    }
}
    

