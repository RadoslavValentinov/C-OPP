using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Vehicles
{
    public class Truck : Vehicles
    {
        private const double airConditional = 1.6;
        public Truck(double fuelquantity, double fuelconsumption)
            : base(fuelquantity, fuelconsumption+airConditional)
        {

        }
        public double Distance { get; set; }

        public override void Drive(double distance)
        {
            if (this.FuelQuantity - (this.FuelConsumption * distance) > 0)
            {
                this.FuelQuantity -= this.FuelConsumption * distance;
                this.Distance += distance;
                Console.WriteLine($"Truck travelled {distance} km");
            }
            else
            {
                Console.WriteLine("Truck needs refueling");
            }
        }

        public override void Refuel(double quantity)
        {
            this.FuelQuantity += quantity * 0.95;
        }
    }
}
