using System;

namespace bookauthor
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Harry Potter", "JkRowling", "Otava", 10 );
            book.GetBookInfo("Harry Potter");
            Book.ChangeTheme("sininen");
            Book book1 = new Book("Harski potter", "JKRowling", "Otava", 15 );
            book1.GetBookInfo("Harski potter");
            Book book2 = new Book("Harski potter", "JKRowling", "Otava", 45);
            
            book2.GetBookInfo("Harsi potter");
            Console.ReadKey();
        }
    }
}
