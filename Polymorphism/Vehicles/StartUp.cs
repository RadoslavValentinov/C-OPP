using System;
using VehiclesExtension;

namespace Vehicles
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] carInput = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
            double fuelquantity = double.Parse(carInput[1]);
            double fuelconsumation = double.Parse(carInput[2]);
            Vehicles car = new Car(fuelquantity,fuelconsumation);
            string[] truckInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            double truckfuel = double.Parse(truckInput[1]);
            double truckconsumation = double.Parse(truckInput[2]);
            Vehicles truck = new Truck(truckfuel,truckconsumation);

            int countcomand = int.Parse(Console.ReadLine());

            for (int i = 0; i < countcomand; i++)
            {
                string[] comand = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string vehicickle = comand[0];

                if (vehicickle=="Drive")
                {
                    string curentVeh = comand[1];
                    double distance = double.Parse(comand[2]);

                    if (curentVeh=="Car")
                    {
                        car.Drive(distance);
                    }
                    else if (curentVeh== "Truck")
                    {
                        truck.Drive(distance);
                    }

                }
                else if (vehicickle== "Refuel")
                {
                    string curentVehicicle = comand[1];
                    double fuel = double.Parse(comand[2]);

                    if (curentVehicicle=="Car")
                    {
                        car.Refuel(fuel);
                    }
                    else if (curentVehicicle== "Truck")
                    {
                        truck.Refuel(fuel);
                    }
                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
           
        }
    }
}
