using System;
using System.Collections.Generic;
using System.Text;

namespace Bankapp
{
    class Customer
    {
        private string _firstName;
        private string _lastName;
        private string accountNumber;

        public Customer(string firstName, string lastName, string accountNumber)
        {
            _firstName = firstName;
            _lastName = lastName;
            this.AccountNumber = accountNumber;
        }

        public string AccountNumber { get => accountNumber; set => accountNumber = value; }
    }
}
