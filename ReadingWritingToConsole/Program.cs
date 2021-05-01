using System;

namespace ReadingWritingToConsole
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter your name ");
            string UserName =Console.ReadLine();

            Console.WriteLine("Please enter last name ");
            string LastName = Console.ReadLine();

            Console.WriteLine("Hello {0} {1}", UserName,LastName);
            //Console.WriteLine("Hello "+UserName);
        }
    }
}
