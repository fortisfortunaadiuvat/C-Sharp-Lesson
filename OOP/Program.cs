using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect1;
            rect1.length = 4;
            rect1.width = 5;

            Console.WriteLine($"Area of the rect1 : {rect1.area()}");

            Rectangle rect2 = new Rectangle(4, 5);

            Console.WriteLine($"Area of the rect2 : {rect2.area()}");
            
            rect1.length = 3;
            rect2 = rect1;
            

            Console.WriteLine($"Area of the rect2 : {rect2.area()}");

            Animal fox = new Animal()
            {
                name = "Red",
                sound = "Raaawww"
            };

            fox.info();

            Animal cow = new Animal()
            {
                name = "Kinali",
                sound = "Mööö"
            };

            cow.info();

            Console.WriteLine($"Number of Animals : {Animal.getNumberOfAnimals()}");

            Console.WriteLine($"Area of Rectangle is: {ShapeMath.GetArea("Rectangle",5,6)}");
            Console.WriteLine($"Area of Circle is: {ShapeMath.GetArea("Circle", 5, 5)}");
        }

        struct Rectangle
        {
            public double length;
            public double width;

            public Rectangle(double l=1,double w = 1)
            {
                length = l;
                width = w;
            }

            public double area()
            {
                return length * width;
            }
        }
    }
}
