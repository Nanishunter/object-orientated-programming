using System;

namespace lipunhinta
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer("Antti Karjalainen", 21, false, false, false );
            customer.TicketPrice();
            Console.ReadKey();
        }
    }
}
