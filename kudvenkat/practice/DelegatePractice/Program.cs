using System;

namespace DelegatePractice
{
    public delegate void HelloFunctionDelegate(string message);
    class Program
    {
        static void Main(string[] args)
        {
            HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);
            del("Hello From delegate");
        }

        public static void Hello(string message)
        {
            Console.WriteLine(message);
        }
    }
}
