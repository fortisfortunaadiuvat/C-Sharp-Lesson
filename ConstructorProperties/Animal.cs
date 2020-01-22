using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConstructorProperties
{
    class Animal
    {
        private string name;
        private string sound;
        public static int numberOfAnimals = 0;
        public readonly int id;

        public Animal(string name = "No Name" , string sound = "No Sound")
        {
            this.name = name;
            this.sound = sound;

            Random rand = new Random();
            id = rand.Next(1, 11);

            numberOfAnimals++;
        }

        public const string shelter = "Hakan's home for Animals";

        
        public Animal(string name = "No Name")
        {
            this.name = name;
            numberOfAnimals++;
        }

        public Animal(int id)
        {
            this.id = id; // it is possible
            id++;
            numberOfAnimals++;
            //shelter = "Darek's home for Animals"; 
            /*it is not possible.
            The readonly keyword is different from the const keyword. 
            A const field can only be initialized at the declaration 
            of the field. A readonly field can be assigned multiple 
            times in the field declaration and in any constructor. 
            Therefore, readonly fields can have different values 
            depending on the constructor used. Also, while a const 
            field is a compile-time constant, the readonly field 
            can be used for runtime constants.*/
        }

        public void makeSound()
        {
            Console.WriteLine($"{name} says {sound}");
        }

        public string getName()
        {
            return name;
        }

        public string getSound
        {
            get { return sound; }
            set
            {
                if(value.Length > 5)
                {
                    sound = "No Sound";
                    Console.WriteLine("The sound is too long");
                }
            }
        }

        public string setName(string name)
        {
            if (!name.Any(char.IsDigit))
            {
                return this.name = name;
            }
            else
            {
                Console.WriteLine("Name can not contain number!");
                return "No Name";
            }   
        }

        public string setSound(string sound)
        {
            return this.sound = sound;
        }

        public static int getNumberOfAnimals
        {
            get { return numberOfAnimals; }
            set { numberOfAnimals += value; }
        }
    }
}
