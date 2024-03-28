using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Box_Data
{
    public class Box
    {

        private double lenght;
        private double width;
        private double height;

        public Box(double lenght, double width, double height)
        {
            this.lenght = lenght;
            this.width = width;
            this.height = height;
        }

        public double Height
        {
            get { return height; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }
                height = value;
            }
        }

        public double Width
        {
            get { return width; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }
                width = value;
            }
        }

        public double Lenght
        {
            get { return lenght; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Lenght cannot be zero or negative.");
                }
                lenght = value;
            }
        }

        //Volume = lwh
        //Lateral Surface Area = 2lh + 2wh
        //Surface Area = 2lw + 2lh + 2wh
        public double ReturnArea()
        {
            return 2 * Lenght * Width + 2 * lenght *  Height + 2 * Width * Height;
        }
       
        public double LateralSurfaceArea()
        {
            return lenght * Height * 2 + Width * Height * 2;
        }
        public double Volume()
        {
            return Lenght * Width * Height;
        }

    }
}
