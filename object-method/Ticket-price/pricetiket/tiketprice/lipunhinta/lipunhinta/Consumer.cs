using System;
using System.Collections.Generic;
using System.Text;

namespace lipunhinta
{
    class Customer
    {
        //Fields
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

        //Methods
        public void AskData()
        {
            Console.WriteLine("Syötä nimesi: ");
            Name = Console.ReadLine();

            bool isNumber;
            do
            {
                Console.WriteLine("Syötä ikäsi: ");
                string age = Console.ReadLine();
                isNumber = int.TryParse(age, out Age);
            } while (isNumber != true);

            string soldier;
            do
            {
                Console.WriteLine("Oletko varusmies? Y/N");
                soldier = Console.ReadLine();
                if (soldier == "Y" || soldier == "y")
                {
                    Soldier = true;
                }
            } while (soldier != "Y" && soldier != "y" && soldier != "N" && soldier != "n");

            string student;
            do
            {
                Console.WriteLine("Oletko opiskelija? Y/N");
                student = Console.ReadLine();
                if (student == "Y" || student == "y")
                {
                    Student = true;
                }
            } while (student != "Y" && student != "y" && student != "N" && student != "n");

            string mtkMember;
            do
            {
                Console.WriteLine("Oletko MTK:n jäsen? Y/N");
                mtkMember = Console.ReadLine();
                if (mtkMember == "Y" || mtkMember == "y")
                {
                    MtkMember = true;
                }
            } while (mtkMember != "Y" && mtkMember != "y" && mtkMember != "N" && mtkMember != "n");
        }

        public void TicketPrice()
        {
            double price = 16.00;

            if (Age < 7)
            {
                price = price - (price * 1);
            }
            else if (Age <= 15)
            {
                price = price - (price * 0.5);
            }
            else if (Age >= 65)
            {
                price = price - (price * 0.5);
            }
            else if (Soldier == true)
            {
                price = price - (price * 0.5);
            }
            else
            {
                if (Student == true)
                {
                    price = price - (price * 0.45);
                }
                if (MtkMember == true)
                {
                    price = price - (price * 0.15);
                }
            }
            Console.WriteLine($"Lopullinen hinta on: {price} e");
        }

        public void PrintCustomerInfo()
        {
            Console.WriteLine($"Asiakkaan nimi: {Name}\nIkä: {Age}\nVarusmies: {Soldier}\nOpiskelija: {Student}\nMTK-jäsen: {MtkMember}");
        }
    }
}