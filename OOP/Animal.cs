using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Animal
    {
        public string name;
        public string sound;
        static int numOfAnimals = 0;

        public Animal(string name = "No Name",string sound = "No Sound")
        {
            this.name = name;
            this.sound = sound;
            numOfAnimals++;
        }

        public void makeSound()
        {
            Console.WriteLine($"{name} says {sound}");
        }

        public static int getNumberOfAnimals()
        {
            return numOfAnimals;
        }

        public void info()
        {
            Console.WriteLine($"The animal {name} has sound {sound}");
        }

    }
}
