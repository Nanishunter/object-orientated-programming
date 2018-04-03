using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Bankapp
{
    class Bank
    {
        //fields

        private List<Account> _accounts;
        private string _name;
        
        //Constructor

        public Bank(string name)
        {
            _name = name;
           _accounts = new List<Account>();
        }
        public Bank(string name, List<Account> accounts)
        {
            _name = name;
            _accounts = accounts;


        }

        public string CreateAccount()
        {
            Random rnd = new Random();
            string rndAccount = "FI";
            for (int i = 0; i < 16; i++) 
            {
                rndAccount += rnd.Next(0,10);
            }
            _accounts.Add(new Account(rndAccount));
            return rndAccount;
            
            
        }
        public bool AddTransactionForCustomer(string accountNumber, Transaction transaction)
        {
            return (from account in _accounts
                    where account.AccountNumber == accountNumber

                    select account).First().Addtransaction(transaction);


        }

        public double GetBalanceForCustomer(string accountNumber)
        {
            return (from account in _accounts
                    where account.AccountNumber == accountNumber
                    select account).FirstOrDefault().Balance;
        }





    }
}
