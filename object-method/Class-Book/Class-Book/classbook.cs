using System;
using System.Collections.Generic;
using System.Text;

namespace taskbook

{
    class classbook
    {
    //Fieldsit
    public string Title;
    public string Author;
    public int Id;
    public double Price;
    
    //Constructor ------->
    public classbook()
    {
        Title = "unknown";
        Author = "unknown";
        Id = 0;
        Price = 0;
    }
    public classbook(string title, string author, int id, double price)
    {
        Title = title;
        Author = author;
        this.Id = id;
        this.Price = price;
    }

        //Methods

        public void Printbookinfo()
        {
            Console.WriteLine($"Kirjan nimi on {Title} ");
            Console.WriteLine($"Kirjailijan nimi on {Author} ");
            Console.WriteLine($"Id on {Id} ");
            Console.WriteLine($"Hinta on {Price} ");
        }
            public string CompareBook(classbook book)
            {
                if (this.Price > book.Price)
                {
                    return $"{this.Title} on kalliimpi kuin {book.Title} kirja";
                }
                else
                {
                    return $"{this.Title} on halvempi kuin {book.Title} kirja";
                }
            }
        }


    }


    

