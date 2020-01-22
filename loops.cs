using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 17;
            bool canDrive = age >= 16 ? true : false;

            Console.WriteLine($"This man can drive: {canDrive}");

            Random rnd = new Random();
            int secretNumber = rnd.Next(1, 11);
            int numberGuess = 0;

            do
            {
                Console.WriteLine("Enter a number between 1 & 10");
                numberGuess = Convert.ToInt32(Console.ReadLine());
            } while (secretNumber != numberGuess);

        }
    }
}
