using System;

namespace staticAndInstanceClass
{

     class Circle
    {
        static float _PI = 3.141F;
        int _Radius;
        public Circle(int Radius)
        {
            _Radius = Radius;
        }
        public float CalculateArea()
        {
            return _PI * _Radius * _Radius;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(5);
            Console.WriteLine("Area = {0}", c1.CalculateArea());

            Circle c2 = new Circle(6);
            Console.WriteLine("Area = {0}",c2.CalculateArea());
        }
    }
}
