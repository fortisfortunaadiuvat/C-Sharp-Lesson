using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal whiskers = new Animal()
            {
                Name = "Whiskers",
                Sound = "Meow"
            };

            Dog groves = new Dog()
            {
                Name = "Groves",
                Sound = "Grrr",
                Sound2 = "Woof"
            };
            
            Console.WriteLine($"Number of Animals: {Animal.numberOfAnimals}");

            whiskers.SetAnimalIDInfo(1234, "Smith");

            whiskers.GetAnimalIDInfo();

            Animal.AnimalHealth getHealthy = new Animal.AnimalHealth();

            Console.WriteLine($"Is my animal healthy: {getHealthy.HealthyWieght(11, 46)}");

            Console.WriteLine($"Length of groves is: {groves.StringLength()}");
        }
    }
}
