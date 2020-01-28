using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LINQ
{
    class AnimalFarm : IEnumerable
    {
        public AnimalFarm() { }

        public IEnumerator GetEnumerator()
        {
            return animalList.GetEnumerator();
        }

        private List<Animal> animalList = new List<Animal>();

        public AnimalFarm(List<Animal> animalList)
        {
            this.animalList = animalList;
        }

        public Animal this[int index]
        {
            get { return (Animal)animalList[index]; }
            set { animalList.Insert(index, value); }
        }

        public int Count
        {
            get { return animalList.Count; }
        }
    }
}
