using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shapes
{
    public class Rectangle : Shape
    {
        private double width;
        private double height;

        public Rectangle(string color, double width, double height) : base(color)
        {
            this.width = width;
            this.height = height;
        }

        public override double GetArea()
        {
            return width * height;
        }
    }
}