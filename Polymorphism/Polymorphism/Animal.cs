using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polymorphism
{
    class Animal
    {
        private string name;
        protected string sound;
        public static int numberOfAnimals;

        protected AnimalInfo animalidinfo = new AnimalInfo();

        public void SetAnimalIDInfo (int id,string owner)
        {
            animalidinfo.AnimalID = id;
            animalidinfo.Owner = owner;
        }

        public void GetAnimalIDInfo()
        {
            Console.WriteLine($"{Name} has id : {animalidinfo.AnimalID} says {Sound} and " +
                $"is owned by {animalidinfo.Owner}");
        }

        public void MakeSound()
        {
            Console.WriteLine($"{name} says {sound}");
        }

        public Animal() 
        {
            numberOfAnimals++;
        }

        public Animal(string name,string sound)
        {
            this.name = name;
            this.sound = sound;
            numberOfAnimals++;
        } 

        public string Name
        {
            get { return name; }
            set
            {
                if (!value.Any(char.IsDigit))
                {
                    name = "No Name";
                }
                name = value;
            }
        }

        public string Sound
        {
            get { return sound; }
            set
            {
                if (value.Length > 5)
                {
                    sound = "No Sound";
                }
                sound = value;
            }
        }

        public class AnimalHealth
        {
            public bool HealthyWieght(double height, double weight)
            {
                double calc = height / weight;

                if ((calc >= .18) && (calc <= .27))
                {
                    return true;
                }
                else
                    return false;
            }
        }

        public virtual int StringLength()
        {
            return name.Length;
        }
    }

}
