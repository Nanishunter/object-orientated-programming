using System;

namespace TryCatchExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku1 = 1, luku2 = 0, osamaara = 0;
            try
            {
                osamaara = luku1 / luku2;
                Console.WriteLine(osamaara);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Jakolaskua ei voitu suorittaa tuntemattoman virheen takia: " + ex.Message);

                Console.ReadLine();
            }
        }
    }
}
