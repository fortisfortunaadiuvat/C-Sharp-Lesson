using System;
using System.Text;

namespace ArrayStringApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            while (count < 10)
            {
                Console.WriteLine($"The value of counter: {count}");
                count++;
            }

            var intVal = 1234;
            Console.WriteLine("The data type is: {0}", intVal.GetType());

            int[] favNumbs = new int[3];
            favNumbs[0] = 7;
            favNumbs[1] = 10;
            favNumbs[2] = 41;

            for(int i = 0; i < favNumbs.Length; i++)
            {
                Console.WriteLine($"Favorite number {i + 1} is {favNumbs[i]}");
            }

            object[] randomstuff = { "Paul", 41, 3.1415 };
            
            for(int j = 0; j < randomstuff.Length; j++)
            {
                Console.WriteLine($"Random object type is {randomstuff[j].GetType()}");
            }

            string[,] customerName = new string[2, 2] { { "Bob", "Mark" } ,{ "Paul", "Eden" } };
            
            for(int k = 0; k < customerName.GetLength(0); k++)
            {
                for(int l = 0; l < customerName.GetLength(1); l++)
                {
                    Console.WriteLine("The customer name is: {0}" , customerName.GetValue(k,l));
                }
            }

            int[] randNumbs = { 1, 3, 2, 0 };

            Array.Sort(randNumbs);
            Array.Reverse(randNumbs);

            Console.WriteLine($"The index of 1 is: {Array.IndexOf(randNumbs, 1)}");

            randNumbs.SetValue(2, 0);

            PrintArray(randNumbs, "Foreach");

            int[] numarr = { 1, 11, 22 };

            Console.WriteLine($">10: {Array.Find(numarr, gt10)}");

            StringBuilder sb = new StringBuilder("Random Text do nothing");
            StringBuilder sb2 = new StringBuilder("More stuff that is important!",256);

            Console.WriteLine($"Capacity sb is: {sb.Capacity}");
            Console.WriteLine($"Capacity sb2 is: {sb2.Capacity}");

            double dec = 3.1415;
            int val = (int)dec;

            Console.WriteLine($"The integer value of dec is: {val}");

        }
        static void PrintArray(int[] arr , string mess)
        {
            foreach(int k in arr)
            {
                Console.WriteLine($"{mess} : {k}");
            }
        }

        private static bool gt10(int k)
        {
            return k > 10;
        }
    }
}
