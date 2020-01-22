using System;

namespace ExcptHand
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 5;
            double y = 0;

            try
            {
                Console.WriteLine($"Result of 5/0 is: {DoSolution(5, 0)}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You can not divide by zero!");
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("All things clean up!");
            }
        }

        static double DoSolution(double x,double y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException();
            }
            else
            {
                return x / y;
            }

        }
    }
}
