using System;
using System.Linq;
using System.Collections.Generic;

namespace LinqExtensionMethod
{
    class Program
    {
        delegate double doubleIt(double val);

        static void Main(string[] args)
        {
            static double dblt(double x) => x * 2;
            Console.WriteLine($"The result of 5*2 is: {dblt(5)}");

            List<int> numList = new List<int> { 1, 3, 9, 6, 4 };

            var evenList = numList.Where(a => a % 2 == 0).ToList();

            foreach(var even in evenList)
            {
                Console.WriteLine($"EvenList : {even}");
            }

            List<int> flipList = new List<int>();

            int i = 0;

            Random random = new Random();

            while (i < 100)
            {
                flipList.Add(random.Next(1, 3));
                i++;
            }

            Console.WriteLine($"Heads : {flipList.Where(a => a == 1).ToList().Count}");
            Console.WriteLine($"Heads : {flipList.Where(a => a == 2).ToList().Count}");

            var nameList = new List<string> { "Sally", "Saul", "Paul", "Mike" };
            var snameList = nameList.Where(x => x.StartsWith("S"));

            foreach(var sname in snameList)
            {
                Console.WriteLine($"Starts with 'S' : {sname}");
            }

            var oneto10 = new List<int>();

            oneto10.AddRange(Enumerable.Range(1, 10));

            var squares = oneto10.Select(x => x * x);

            foreach(var sq in squares)
            {
                Console.WriteLine($"{sq}");
            }

            var list1 = new List<int>(new int[] { 1, 2, 3 });
            var list2 = new List<int>(new int[] { 2, 4, 6 });

            var sumList = list1.Zip(list2, (x, y) => x + y).ToList();

            foreach(var sum in sumList)
            {
                Console.WriteLine($"{sum}");
            }

        }
    }
}
