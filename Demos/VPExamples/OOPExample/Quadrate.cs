using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExample
{
    public class Quadrate : Figure
    {
        private double _side;

        public double Side
        {
            get
            {
                return _side;
            }

            set
            {
                if (value > 0)
                {
                    _side = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Side should be more than 0");
                }
            }
        }

        public Quadrate(string name, double side) : base(name)
        {
            Side = side;
        }

        public override double Perimeter
        {
            get
            {
                return Side * 4;
            }
        }

        public override double Square
        {
            get
            {
                return Side * Side;
            }
        }
    }
}
