using System;

namespace explicitInterface
{
    interface I1
    {
        void InterfaceMethod();
    }
    interface I2
    {
        void InterfaceMethod();
    }
    class Program:I1,I2
    {
        void I1.InterfaceMethod()
        {
            Console.WriteLine("I1 interface Method");
        }
        void I2.InterfaceMethod()
        {
            Console.WriteLine("I2 interface Method");
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            ((I1)program).InterfaceMethod();
            ((I2)program).InterfaceMethod();
        }

        
    }
}
