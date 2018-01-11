using System;

namespace TaskPerson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Person personAntti = new Person();
            personAntti.Name = "Antti";
            Console.WriteLine($"Antin ikä:{personAntti.GetAge()}");

            personAntti.GrowOld();
            Console.WriteLine($"Antin ikä:{personAntti.GetAge()}");
            personAntti.GrowOld(50);
            personAntti.PrintPersonInfo();

            Person newPerson = new Person("Joe Doe", 18);
            newPerson.PrintPersonInfo();
            newPerson.GrowOld();
            newPerson.PrintPersonInfo();
            Console.ReadKey();
            
        }
    }
}
