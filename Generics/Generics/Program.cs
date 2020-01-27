using System;
using System.Linq;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animalList = new List<Animal>();

            animalList.Add(new Animal { Name = "Doug" });
            animalList.Add(new Animal { Name = "Paul" });
            animalList.Add(new Animal { Name = "Sally" });

            animalList.Insert(1, new Animal { Name = "Steve" });

            foreach(Animal animal in animalList)
            {
                Console.WriteLine($"{animal.Name}");
            }

            int x = 4;
            int y = 5;

            GetSum(ref x, ref y);

            Rectangle<int> rectangle = new Rectangle<int>(4, 5);
            Rectangle<string> rectangle2 = new Rectangle<string>("2", "2.5");

            Console.WriteLine($"The rectangle area is: {rectangle.getArea()}");
            Console.WriteLine($"The rectangle2 area is: {rectangle2.getArea()}");

        }

        public static void GetSum<T>(ref T num1,ref T num2)
        {
            double dblX = Convert.ToDouble(num1);
            double dblY = Convert.ToDouble(num2);

            Console.WriteLine($"{dblX} + {dblY} = {dblX + dblY}");
        }

        public struct Rectangle<T>
        {
            private T length;
            private T width;

            public T Width
            {
                get { return width; }
                set { width = value; }
            }

            public T Length
            {
                get { return length; }
                set { length = value; }
            }

            public Rectangle(T l,T w)
            {
                length = l;
                width = w;
            }

            public string getArea()
            {
                double dx = Convert.ToDouble(Width);
                double dy = Convert.ToDouble(Length);

                return string.Format($"{Width} * {Length} = {dx * dy}");
            }
        }
    }
}
