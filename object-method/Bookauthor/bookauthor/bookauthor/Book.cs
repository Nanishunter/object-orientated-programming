using System;
using System.Collections.Generic;
using System.Text;

namespace bookauthor
{
    class Book
    {
        //Fields

        public string Name;
        public string Author;
        public string Publisher;
        private double _price;
        static string ThemeName;
        
        public Book()
        {
            Name = null;
            Author = null;
            Publisher = null;
            _price = 0;
            ThemeName = null;
        }

        public Book(string name, string author, string publisher, double price)
        {
            Name = name;
            Author = author;
            Publisher = publisher;
            _price = price;
            



        }



        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value > 30)
                {
                    _price = value * 0.9;
                }
                else
                {
                    _price = value;
                }
            }


        }
        public void GetBookInfo( string name)
        {
            if (Name == name)
            {
                Console.WriteLine($"Kirjailijan nimi on {Author}, Kirjan nimi on {Name} , Kirjan hinta on {Price} Teeman nimi on {ThemeName} ");

            }
            else
            {
                Console.WriteLine("Kirjaa ei löydy");
            }
               

        }
        public static void ChangeTheme( string theme )
        {
            ThemeName = theme;
            

        }
        
        

        

    }
}
