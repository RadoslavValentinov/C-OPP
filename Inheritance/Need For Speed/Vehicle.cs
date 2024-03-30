using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed.Classs
{
    public class Vehicle
    {
        private const double DefaultFuelConsumption = 1.25;
        public Vehicle(int horsePower,double fuel)
        {
            HorsePower = horsePower;
            Fuel = fuel;
            this.FuelConsumption = DefaultFuelConsumption;
        }

        public virtual double FuelConsumption { get; set; }
        public double Fuel { get; set; }
        public int HorsePower { get; set; }

        public virtual void Drive(double kilometers)
        {
            this.Fuel -= FuelConsumption * kilometers;
        }
    }
}
