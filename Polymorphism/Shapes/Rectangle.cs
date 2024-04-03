using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Rectangle : Shape
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }
        public double Height
        {
            get { return height; }
            private set { height = value; }
        }

        public double Width
        {
            get { return width; }
            private set { width = value; }
        }


        public override double CalculatePerimeter()
        {
            return 2 * Width + 2 * Height;
        }

        public override double CalculateArea()
        {
            return Width * Height;
        }

        public override string Draw()
        {
            return base.Draw() + this.GetType().Name;
        }
    }
}
