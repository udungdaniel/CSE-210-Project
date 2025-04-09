using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace shapes
{
    public class Square : Shape
    {
        private double side;

        public Square(string color, double side) : base(color)
        {
            this.side = side;
        }

        public override double GetArea()
        {
            return side * side;
        }
    }
}
