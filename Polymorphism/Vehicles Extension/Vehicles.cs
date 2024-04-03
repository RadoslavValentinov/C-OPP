using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesExtension
{
    public abstract class Vehicles
    {
        private double fuelquantity;
        private  double fuelconsumption ;
        private double tankcapacity;
        protected Vehicles(double fuelquantity, double fuelconsumption,double tankcapacity)
        {
            this.FuelQuantity = fuelquantity;
            this.FuelConsumption = fuelconsumption;
            this.TankCapacity = tankcapacity;
        }

        public virtual double  FuelConsumption 
        {
            get { return fuelconsumption ; }
            set { fuelconsumption  = value; }
        }
        public double TankCapacity
        {
            get
            {
                return tankcapacity;
            }
            private set
            {
                if (this.FuelQuantity > this.TankCapacity)
                {
                    value = 0;
                }
                tankcapacity = value;
            }
        }
        public double FuelQuantity
        {
            get { return fuelquantity; }
            set { fuelquantity = value; }
        }

        public virtual void Refuel(double quantity)
        {
            this.FuelQuantity += quantity;
        }
        public virtual void Drive(double distance)
        {

        }
    }
}
