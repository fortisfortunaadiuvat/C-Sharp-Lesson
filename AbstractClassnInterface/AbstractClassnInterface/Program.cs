using System;

namespace AbstractClassnInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = { new Circle(5), new Rectangle(4, 5) };
            
            foreach(Shape s in shapes)
            {
                s.GetInfo();

                Console.WriteLine($"{s.Name} area: {s.Area():f2}");
            }
        }
    }
}
