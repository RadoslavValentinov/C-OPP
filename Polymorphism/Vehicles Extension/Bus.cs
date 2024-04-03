using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesExtension
{
    public class Bus: Vehicles
    {
        private const double airConditionalON = 1.4;

        public Bus(double fuelquantity, double fuelconsumption, double tankcapacity,string people) 
            : base(fuelquantity, fuelconsumption+airConditionalON, tankcapacity)
        {
            this.PeopleOrNot = people;
        }
        public Bus(double fuelquantity, double fuelconsumption, double tankcapacity)
            : base(fuelquantity, fuelconsumption+airConditionalON, tankcapacity)
        {
        }

        public string PeopleOrNot { get; set; }
        public override void Drive(double distance)
        {
            if (this.PeopleOrNot=="Empty")
            {
                this.FuelConsumption -= airConditionalON;
            }
            base.Drive(distance);
        }

        public override double FuelConsumption
        {
            get => base.FuelConsumption;
            set => base.FuelConsumption = value;
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
