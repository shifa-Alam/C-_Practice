using System;

namespace AbstractClass
{


    abstract class Customer
    {
        public abstract void print();
        
    }
    class Program:Customer
    {
        public override void print()
        {
            Console.WriteLine("Print Method");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.print();
        }


    }
}
