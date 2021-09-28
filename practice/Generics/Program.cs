using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
           var result = Calculator<string>.AreEqual("A", "B");
            Console.WriteLine(result);
        }
    }
}
