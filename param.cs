using System;

namespace Param
{
    class Program
    {
        static void Main(string[] args)
        {
            int solution;

            DoubleIt(15, out solution);

            Console.WriteLine($"Result of 15*2 is: {solution}");

            int num1 = 10;
            int num2 = 20;

            Console.WriteLine($"Before swapping num1 is: {num1} " +
                                $"and num2 is: {num2}");
            
            Swap(ref num1, ref num2);

            Console.WriteLine($"After swapping num1 is: {num1} " +
                                $"and num2 is: {num2}");

            Console.WriteLine($"Result of 1+2+3 is: {getSomeMore(1, 2, 3)}");

            printInfo(zipcode: 41110, name: "Hakan");

        }

        static void DoubleIt(int x, out int solution)
        {
            solution = x * 2;
        }

        public static void Swap(ref int num1,ref int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }

        static double getSomeMore(params double[] nums)
        {
            int sum = 0;

            foreach(int i in nums)
            {
                sum += i;
            }

            return sum;
        }

        static void printInfo(string name,int zipcode)
        {
            Console.WriteLine($"{name} lives in zipcode {zipcode}");
        }
    }
}
