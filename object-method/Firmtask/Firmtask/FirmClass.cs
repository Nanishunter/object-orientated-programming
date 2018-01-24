using System;
using System.Collections.Generic;
using System.Text;

namespace Firmtask
{
    class FirmClass
    {
        //Fields
        public string Title;
        public string Adress;
        public int Phone;
        private double _Outcome;
        private double _Expense;

        //Constructor 

        public FirmClass()
        {

            Title = "unknown";
            Adress = "unknown";
            Phone = 0;
            _Outcome = 0;
            _Expense = 0;

        }


        public FirmClass(string title, string adress, int phone, double outcome, double expense)
        {

            Title = title;
            Adress = adress;
            this.Phone = phone;
            this._Outcome = outcome;
            this._Expense = expense;
            //Copy Constructor
            

        }
        public FirmClass(FirmClass previousFirmclass)
            {

        }
            )
    }
}
























