using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExample
{
    public class Round : Figure
    {
        private double _radius;
        public double Radius
        {
            get
            {
                return _radius;
            }

            set
            {
                if(value > 0)
                {
                    _radius = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Radius should be more than 0");
                }
            }
        }

        public Round(string name, double radius) : base(name)
        {
            Radius = radius;
        }

        public override double Perimeter
        {
            get
            {
                return 2 * Math.PI * Radius;
            }
        }

        public override double Square
        {
            get
            {
                return Math.PI * Radius * Radius;
            }
        }
    }
}
