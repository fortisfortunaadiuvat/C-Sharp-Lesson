using System;

namespace OverloadingnEnumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalFarm myAnimal = new AnimalFarm();

            myAnimal[0] = new Animal("Wilbur");
            myAnimal[1] = new Animal("Templeton");
            myAnimal[2] = new Animal("Gander");
            myAnimal[3] = new Animal("Charlotte");

            foreach(Animal animal in myAnimal)
            {
                Console.WriteLine($"Name : {animal.Name}");
            }

            Console.WriteLine("");

            Box box1 = new Box(1, 2, 3);
            Box box2 = new Box(2, 4, 6);

            Box box3 = box1 + box2;

            Console.WriteLine($"Box3 information: \n{box3}");
            Console.WriteLine("");
            Console.WriteLine($"Box int: {(int)box3}");
            Console.WriteLine("");

            Box box4 = (Box)4;

            Console.WriteLine($"Box4 information: \n{(Box)box4}");

            var shopkins = new{
                Name = "Shopkins",
                Price = "4.99"
            };

            Console.WriteLine("");

            Console.WriteLine($"{shopkins.Name} costs ${shopkins.Price}");

            Console.WriteLine("");

            var toyArray = new[]
            {
                new{Name = "Yu-Gi-Oh Pack",Price=4.99 },
                new{Name = "Legos",Price=9.99 },
            };

            foreach(var item in toyArray)
            {
                Console.WriteLine($"{item.Name} costs ${item.Price}");
            }
        }
    }
}
