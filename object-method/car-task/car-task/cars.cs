
using System;
using System.Collections.Generic;
using System.Text;

namespace task1
{
    class Car
    {
        //Fields
        public string Brand;
        public double Speed;

        //Constructor
        public Car()

        {
            Brand = "unknown";
            Speed = 0;
        }

        public Car(string brand, int speed)
        {
            Brand = brand;
            this.Speed = speed;

        }
        public void AskData()

        {
            //Methods
            Console.WriteLine($"Syötä auton merkki:");
            Brand = Console.ReadLine();
            Console.WriteLine($"Syötä auton nopeus:");
            Speed = int.Parse(Console.ReadLine());
        }
        public void ShowCarInfo()
        {
            Console.WriteLine($"Auton merkki on {Brand}");
            Console.WriteLine($"Auton nopeus on {Speed}");

        }
        public void Brake()
        {
            Speed = 0.9 * Speed;
            Console.WriteLine($"alennettu nopeus {Speed}");

        }
        public void Accelerate()
        {
            Console.WriteLine($"Nopeuteen lisätään ");

            if (Speed < 0)
            {
                Console.WriteLine("Negatiivinen tulos ei ole mahdollinen");

                
            }
            else
            {
                Speed++;
                Console.WriteLine("Uusi nopeus on ");
            }

            
        }
    
            







        

























     }
    }

