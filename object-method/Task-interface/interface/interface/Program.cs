using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            //Greate store where all Products are stored
            Product[] products = new Product [ 3 ];
            products[0] = new Product("Olut", 1, 3);
            products[1] = new Product("Olutkahvi", 45, 7);
            products[2] = new Product("Ruoka", 5, 6);

            products[0].GetProduct("Olut");
            products[1].GetProduct("Olutkahvi");
            products[2].GetProduct("Ruoka");

            products[0].CalculateTotalValue();
            products[1].CalculateTotalValue();
            products[2].CalculateTotalValue();

            Console.WriteLine($"Oluen lukumäärä*hinta on = { products[0].CalculateTotalValue()} euroa" +
                $"");
            Console.WriteLine($"Olutkahvien lukumäärä*hinta on = { products[1].CalculateTotalValue()} euroa");
            Console.WriteLine($"Ruoan lukumäärä*hinta on = { products[2].CalculateTotalValue()} euroa");





            Console.ReadKey();
        }
    }
}
