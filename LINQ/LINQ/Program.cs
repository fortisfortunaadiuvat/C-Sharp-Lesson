using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            QueryStringArray();
            QueryIntArray();
            QueryArrayList();
            QueryCollection();
        }

        static void QueryStringArray()
        {
            string[] dogs = { "K 9", "Kobe", "Scobby Doo", "Lassie" };

            var dogSpaces = from dog in dogs
                            where dog.Contains(" ")
                            orderby dog ascending
                            select dog;

            Console.WriteLine($"Order by dog contains space :");

            foreach (var space in dogSpaces)
            {
                Console.WriteLine($"{space}");
            }
        }

        static int[] QueryIntArray()
        {
            int[] nums = { 5, 10, 15, 20, 25, 30 };

            var gt20 = from num in nums
                       where num>20
                       orderby num
                       select num;

            foreach(var n in gt20)
            {
                Console.WriteLine(n);
            }

            var gt20List = gt20.ToList<int>();
            var gt20ArrayList = gt20.ToArray();

            return gt20ArrayList;
            
        }

        static void QueryArrayList()
        {
            ArrayList famAnimals = new ArrayList()
            {
                new Animal
                {
                    Name = "Heidi",
                    Height = .8,
                    Weight = 18
                },

                new Animal
                {
                    Name = "Shrek",
                    Height = 4,
                    Weight = 130
                },

                new Animal
                {
                    Name = "Congo",
                    Height = 3.8,
                    Weight = 90
                }
            };

            var famAnimalEnum = famAnimals.OfType<Animal>();

            var smAnimal = from animal in famAnimalEnum
                           where animal.Weight <= 90
                           orderby animal.Name
                           select animal;

            foreach(var animal in smAnimal)
            {
                Console.WriteLine($"{animal.Name}'s height is {animal.Height} and " +
                                  $"weight is {animal.Weight}");
            }
        }

        static void QueryCollection()
        {
            var animalList = new List<Animal>()
            {
                new Animal
                {
                    Name = "German Shepherd",
                    Height = 25,
                    Weight = 77
                },

                new Animal
                {
                    Name = "Chupa",
                    Height = 41,
                    Weight = 52
                },

                new Animal
                {
                    Name = "Ingolar",
                    Height = 30,
                    Weight = 200
                },
            };

            var bigDogs = from dog in animalList
                          where (dog.Height > 25) && (dog.Weight > 75)
                          orderby dog.Name
                          select dog;

            foreach(var dog in bigDogs)
            {
                Console.WriteLine($"{dog.Name}'s height is {dog.Height} and " +
                                  $"wight is {dog.Weight}");
            }
        }
    }
}
