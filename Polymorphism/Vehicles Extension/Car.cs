using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesExtension
{
    public class Car:Vehicles
    {
        private const double airConditional = 0.9;
        public Car(double fuelquantity, double fuelconsumption,double tankCapasity) 
            : base(fuelquantity,fuelconsumption+airConditional,tankCapasity)
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
            if (quantity > this.TankCapacity)
            {
                Console.WriteLine($"Cannot fit {quantity} fuel in the tank");
            }
            else if (quantity <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            else
            {
                base.Refuel(quantity);
            }
        }
    }
}
