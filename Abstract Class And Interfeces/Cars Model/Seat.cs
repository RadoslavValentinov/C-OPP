using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class Seat : ICar
    {
        public Seat(string model,string color)
        {
            Model = model;
            Color = color;
        }
        public string Model { get; set; }
        public string Color { get; set; }
        public string Start()
        {
            return $"Breaaak!";
        }

        public string Stop()
        {
            return $"Engine start";
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Color} {GetType()} {this.Model}");
            sb.AppendLine(Stop());
            sb.AppendLine(Start());

            return sb.ToString().TrimEnd();
        }
    }
}
