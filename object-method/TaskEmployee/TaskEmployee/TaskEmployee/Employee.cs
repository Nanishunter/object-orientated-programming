using System;
using System.Collections.Generic;
using System.Text;

namespace TaskEmployee
{
    class Employee
    {
        //Fields
        string Name;
        int Id;
        string Position;
        double Salary;

        //Constructor
        public Employee()
        {
            Name = null;
            Id = 0;
            Position = null;
            Salary = 0.00;
        }

        public Employee(string name, int id, string position, double salary)
        {
            Name = name;
            Id = id;
            Position = position;
            Salary = salary;
        }

        //Methods
        public string CompareSalary(Employee employee)
        {
            if (Salary > employee.Salary)
            {
                return ($"Henkilön { Name } palkka on suurempi kuin henkilön { employee.Name } palkka.");
            }
            else if (Salary < employee.Salary)
            {
                return ($"Henkilön { employee.Name } palkka on suurempi kuin henkilön { Name } palkka.");
            }
            else
            {
                return ($"Henkilön { Name } palkka on sama kuin henkilön { employee.Name } palkka.");
            }
        }

        public void PrintEmployeeInfo()
        {
            Console.WriteLine($"Työntekijän nimi: {Name}\nId: {Id}\nTehtävä: {Position}\nPalkka: {Math.Round(Salary)}");
            Console.WriteLine();
        }
    }
}
