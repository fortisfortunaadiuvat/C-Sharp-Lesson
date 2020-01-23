using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Dog : Animal
    {
        public string Sound2 { get; set; } = "Grrr";

        public new void MakeSound()
        {
            Console.WriteLine($"{Name} says {Sound} and {Sound2}");
        }

        public Dog(){}

        public Dog(string name = "No Name",
                    string sound = "No Sound",
                     string sound2 = "No Sound2")
            :base(name, sound)
        {
            Sound2 = sound2;
        }

        public override int StringLength()
        {
            return base.StringLength();
        }

    }
}
