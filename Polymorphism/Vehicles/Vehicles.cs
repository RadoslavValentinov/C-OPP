using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public abstract class Vehicles
    {
        private double fuelquantity;
        private  double fuelconsumption ;

        protected Vehicles(double fuelquantity, double fuelconsumption)
        {
            this.FuelQuantity = fuelquantity;
            this.FuelConsumption = fuelconsumption;
        }

        public virtual double  FuelConsumption 
        {
            get { return fuelconsumption ; }
            set { fuelconsumption  = value; }
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
