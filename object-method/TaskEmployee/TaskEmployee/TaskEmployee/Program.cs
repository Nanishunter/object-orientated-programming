using System;

namespace TaskEmployee
{
    class Program
    {
        static void Main(string[] args)
        {
            //Luodaan tyontekijät-taulukko, jolla on kolme alkiota ja sitten sen olio-alkiot alustetaan.

            Employee[] employees = new Employee[3];
            employees[0] = new Employee("Arto-mestari", 1, "Johtaja", 5000.00);
            employees[1] = new Employee("Antti Karjalainen", 2, "Työnjohtaja", 2500.00);
            employees[2] = new Employee("Kari ", 3, "Rehellinen mies", 6000.00);

            //Tulostetaan työntekijöiden tiedot näytölle

            employees[0].PrintEmployeeInfo();
            employees[1].PrintEmployeeInfo();
            employees[2].PrintEmployeeInfo();
            Console.WriteLine();

            //Verrataan työntekijöiden palkkoja

            Console.WriteLine(employees[0].CompareSalary(employees[1]));
            Console.WriteLine(employees[0].CompareSalary(employees[2]));
            Console.WriteLine(employees[1].CompareSalary(employees[2]));

            Console.ReadKey();

        }
    }
}
