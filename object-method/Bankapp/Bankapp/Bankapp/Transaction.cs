using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Bankapp
{
    class Transaction
    {
        private double _sum;
        private DateTime _timeStamp;

        public Transaction(double sum, DateTime timeStamp)
        {
            Sum = sum;
            _timeStamp = timeStamp;
        }

        public double Sum { get => _sum; set => _sum = value; }
    }
}
