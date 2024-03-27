using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Circle : IDrawable
    {
        private int radius;

        public Circle(int radios)
        {
            Radius = radios;
        }


        public int Radius
        {
            get { return radius; }
            set { radius = value; }
        }


        public void Draw()
        {
            double radIn = this.Radius - 0.4;
            double radOut = this.Radius + 0.4;

            for (double y = this.Radius; y >= -this.Radius; y--)
            {
                for (double x = -this.Radius; x < radOut; x += 0.5)
                {
                    double value = x * x + y * y;

                    if (value >= radIn * radIn && value <= radOut * radOut)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
