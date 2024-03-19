using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsExample
{
    class Cat
    {
        public void CatHandler() => Console.WriteLine("Мяу! Событие получил котик");

    }

    class Dog
    {
        public void DogHandler() => Console.WriteLine("Гав! Событие получил пёсик");

    }

    class Bird
    {
        public static void BirdHandler()
        {
            Console.WriteLine("Чирик! Событие получила птичка");
        }
    }

    class Fox
    {
        public string Name { get; private set; }
        public Fox(string name)
        {
            Name = name;
        }

        public void FoxHandler()
        {
            Console.WriteLine($"Фыр! Событие получила лисичка по имени {Name}");
        }
    }
}
