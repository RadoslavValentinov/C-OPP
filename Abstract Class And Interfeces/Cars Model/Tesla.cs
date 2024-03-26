using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class Tesla : ICar,IElectricCar
    {
       
        public Tesla(string model, string color, int battery)
        {
            Model = model;
            Color = color;
            Battery = battery;
        }
        public string Model { get; set; }
        public string Color { get; set; }
        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak!";
        }

        public int Battery { get; set; }

        public override string ToString()
        {
            StringBuilder sv = new StringBuilder();
            sv.AppendLine($"{this.Color} {GetType()} {this.Model}");
            sv.AppendLine(Start());
            sv.AppendLine(Stop());
            return sv.ToString().TrimEnd();
        }
    }
}
