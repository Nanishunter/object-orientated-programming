using System;
using System.Collections.Generic;

namespace Bankapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bankapp V 1.0.");
            Bank bank = new Bank("IsoPankki");
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer("Antti", "Karjalainen", bank.CreateAccount()));
            customers.Add(new Customer("Riku", "Karjalainen", bank.CreateAccount()));
            customers.Add(new Customer("Aku", "Karjalainen", bank.CreateAccount()));





            bank.AddTransactionForCustomer(customers[0].AccountNumber,
                new Transaction(1234, new DateTime(2018, 03, 23)));

            

        }
        public static void PrintBalance(Bank bank, Customer customer)
        {
            var balance = bank.GetBalanceForCustomer(customer.AccountNumber);
            Console.WriteLine("{0} - balance: {1}{2:0.00}",
            customer.ToString(), balance >= 0 ? "+" : "", balance);

            Console.ReadKey();





        }
       
        
    }
}
