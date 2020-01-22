using System;

namespace ConstructorProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal fox = new Animal("Red","Raaww");

            Console.WriteLine($"The {fox.getName()} says {fox.getSound}");
            Console.WriteLine($"The {fox.getName()} has {fox.id} ID number");

            Console.WriteLine($"Number of Animal is: {Animal.getNumberOfAnimals}");
            
        }
    }
}
