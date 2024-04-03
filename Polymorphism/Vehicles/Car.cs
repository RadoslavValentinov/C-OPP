using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesExtension
{
    public class Car:Vehicles.Vehicles
    {
        private const double airConditional = 0.9;
        public Car(double fuelquantity, double fuelconsumption) 
            : base(fuelquantity,fuelconsumption+airConditional)
        {
        }

        public double Distance { get; set; }

        public override void Drive(double distance)
        {
            if (this.FuelQuantity - (this.FuelConsumption * distance) > 0)
            {
                this.FuelQuantity -= this.FuelConsumption * distance;
                this.Distance += distance;
                Console.WriteLine($"Car travelled {distance} km");
            }
            else
            {
                Console.WriteLine("Car needs refueling");
            }
        }

        public override void Refuel(double quantity)
        {
            base.Refuel(quantity);
        }
    }
}
