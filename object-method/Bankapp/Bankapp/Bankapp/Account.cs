using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Bankapp
{
    class Account
    {

        //Constructor
        private string _accountNumber;
        private double _balance;
        private List<Transaction> _transactions;

        public Account(string accountNumber)
        {
            _accountNumber = accountNumber;
            _transactions = new List<Transaction>();
            
        }

        public Account (string accountNumber , double balance, List<Transaction> transactions)
        {
            _accountNumber = accountNumber;
            Balance = balance;
            _transactions = transactions;
        }
        
        public double Balance { get => _balance; set => _balance = value; }
        public string AccountNumber { get => _accountNumber; set => _accountNumber = value; }
        

        public bool Addtransaction(Transaction transaction)
        {
            bool res = false;

                _transactions.Add(transaction);
            double balanceBeforeTransaction = Balance;
            if (_transactions.Last().Equals(transaction))
            {
                Balance += transaction.Sum;

            }
            if (Balance - transaction.Sum == balanceBeforeTransaction)
            {
                res = true;
            }
            return res;
        }

        
    }
}
