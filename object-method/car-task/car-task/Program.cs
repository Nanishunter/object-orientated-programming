using System;
using task1;

namespace taskcar
{
    class Program
    {
        static void Main(string[] args)
            
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Car car = new Car( );
            car.AskData();
            car.ShowCarInfo();
            Console.WriteLine();
            car.Brake();

            Car car1 = new Car();
            car.AskData();
            car.ShowCarInfo();
            Console.WriteLine();
            

            Car car2 = new Car();
            car.AskData();
            car.ShowCarInfo();
            car.Accelerate();
            Console.ReadKey();




        }
    }
}
