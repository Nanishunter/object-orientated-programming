using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class Product
        
    {
        //Fields
        public string Name;
        public decimal UnitPrice;
        public int Number;
        //Constructor
        public Product (string name, decimal unitprice, int number)
        {
            Name = name;
            UnitPrice = unitprice;
            Number = number;
        }
        //Methods
        public override string ToString()
        {
           return ($" Nimi on {Name}, yksikköhinta on {UnitPrice} ja lukumäärä on {Number}.");
        }
        public void GetProduct(string name)
        {
            if (Name == name)
            {
                Console.WriteLine($" Nimi on {Name}, yksikköhinta on {UnitPrice} ja lukumäärä on {Number}.");

            }
            else
            {
                Console.WriteLine("Tuotetta ei löydy");
            }

        }
        public decimal CalculateTotalValue()
        {
            decimal totalValue = UnitPrice * Number;
            return totalValue;

            
        }

    }
    
}
