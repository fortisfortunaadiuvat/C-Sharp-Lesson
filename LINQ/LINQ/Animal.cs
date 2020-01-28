using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ
{
    class Animal
    {
        public string Name { get; set; }
        public double Height{ get; set; }
        public double Weight { get; set; }
        public int AnimalID { get; set; }

        public Animal(string name = "No Name", double height = 0,double weight = 0)
        {
            Name = name;
            Height = height;
            Weight = weight;
        }

        public override string ToString()
        {
            return string.Format($"Name : {Name} Height : {Height} Weight : {Weight}");
        }
    }
}
