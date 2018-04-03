using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Bankapp
{
    class Customer
    {
        private string _firstName;
        private string _lastName;
        private string _accountNumber;

        public Customer(string firstName, string lastName, string accountNumber)
        {
            _firstName = firstName;
            _lastName = lastName;
            this._accountNumber = accountNumber;
        }

        public string AccountNumber { get => _accountNumber; set => _accountNumber = value; }
    }
}
