using System;
using System.Numerics;

namespace SampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string mystr = "Hello World!";

            for(int i = 0; i < mystr.Length; i++)
            {
                Console.WriteLine(mystr[i]);
            }

            sayHello();

            bool booldatatype = bool.Parse("true");

            if(booldatatype == true)
            {
                int data = int.Parse("100");
                Console.WriteLine(data);
            }

            DateTime date = new DateTime(1997, 04, 14);
            Console.WriteLine("The day of week: {0}", date.DayOfWeek);

            string str = "This is a string";
            
            Console.WriteLine("str length is: {0}", str.Length);
            Console.WriteLine("str contains 'is ': {0}", str.Contains("is"));
            Console.WriteLine("str remove operation: {0}", str.Remove(0, 6));
            Console.WriteLine("str insert : {0}", str.Insert(10, "short "));
            Console.WriteLine("str replace operation: {0}", str.Replace("string", "sentences"));
            Console.WriteLine("str pad left: {0}" , str.PadLeft(19,'.'));
            Console.WriteLine("str pad right: {0}", str.PadRight(19, '.'));

            string newstr = String.Format("{0} saw a {1} {2} in the {3}",
                                            "Paul", "rabbit", "eating", "field");
            Console.WriteLine(newstr);

            Console.WriteLine(@"Exactly what i typed: '\");
        }

        private static void sayHello()
        {
            string name = "";
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("Hello {0} ", name);
        }
    }
}
