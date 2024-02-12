using System;

namespace OOPExample
{
    public abstract class Figure
    {
        public string Name { get; private set; }

        public abstract double Perimeter { get; }

        public abstract double Square { get; }

        public Figure()
        {

        }

        public Figure(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"This is {Name}, P = {Perimeter}, S = {Square}";
        }
    }
}
