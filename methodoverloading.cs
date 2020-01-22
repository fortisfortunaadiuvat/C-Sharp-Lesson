using System;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Result of 5.0 + 4.5 is: {getSum(5.0,4.5)}");
            Console.WriteLine($"Result of 5.0 + 4.5 is: {getSum("5.0", "4.5")}");

            carColor car1 = carColor.Blue;
            paintCar(car1);
        }
        static double getSum(double x,double y)
        {
            return x + y;
        }

        //Method Overloading Operation
        static double getSum(string x, string y)
        {
            double doubx = Convert.ToDouble(x);
            double douby = Convert.ToDouble(y);
            return doubx + douby;
        }

        enum carColor : byte
        {
            Orange = 1,
            Blue,
            Green,
            Yellow,
            Red
        }

        static void paintCar(carColor cc)
        {
            Console.WriteLine($"The car was painted {cc} with code {(int)cc}");
        }
    }
}
