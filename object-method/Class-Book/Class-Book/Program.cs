using System;

namespace taskbook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            classbook book = new classbook("Harry Potter", "JK ROWLING", 179012, 22.90);
            book.Printbookinfo();
            Console.WriteLine();

            classbook nbook = new classbook("Vares", "Ilkka Remes", 170183, 69.90);
            book.Printbookinfo();
            Console.WriteLine();

            Console.WriteLine($"{book.CompareBook(nbook)}");
            Console.ReadKey();

        }
    }
}
