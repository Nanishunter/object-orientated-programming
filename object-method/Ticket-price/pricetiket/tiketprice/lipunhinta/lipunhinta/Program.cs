using System;

namespace lipunhinta
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.AskData();
            Console.WriteLine();
            customer1.PrintCustomerInfo();
            Console.WriteLine();
            customer1.TicketPrice();
            Console.ReadKey();
        }
    }
}
