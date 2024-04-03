using System;

namespace VehiclesExtension
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] inputvehicle = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            double fuelAmaunt = double.Parse(inputvehicle[1]);
            double fuelConsumation = double.Parse(inputvehicle[2]);
            double tankCapasity = double.Parse(inputvehicle[3]);
            Vehicles car = new Car(fuelAmaunt,fuelConsumation,tankCapasity);

            string[] inputTruck = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            double fuelAmauntTruck = double.Parse(inputvehicle[1]);
            double fuelConTruck = double.Parse(inputvehicle[2]);
            double tankCapasityTruck = double.Parse(inputvehicle[3]);
            Vehicles truck = new Truck(fuelAmauntTruck,fuelConTruck,tankCapasityTruck);

            string[] inputBus = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            double fuelAmauntBus = double.Parse(inputvehicle[1]);
            double fuelConsumationBus = double.Parse(inputvehicle[2]);
            double tankCapasityBus = double.Parse(inputvehicle[3]);
            Vehicles bus = new Bus(fuelAmauntBus,fuelConsumationBus,tankCapasityBus);

            int countcomand = int.Parse(Console.ReadLine());

            for (int i = 0; i < countcomand; i++)
            {
                string[] comand = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string vehicickle = comand[0];

                if (vehicickle == "Drive")
                {
                    string curentVeh = comand[0];
                    
                    if (curentVeh == "Car")
                    {
                        double distance = double.Parse(comand[2]);
                        car.Drive(distance);
                    }
                    else if (curentVeh == "Truck")
                    {
                        double distance = double.Parse(comand[2]);
                        truck.Drive(distance);
                    }
                    else if (curentVeh=="Bus")
                    {
                        double distance = double.Parse(comand[2]);
                        bus.Drive(distance);
                    }
                    else if (curentVeh== "DriveEmpty")
                    {
                        bus.FuelConsumption -= 1.4;
                        double distance = double.Parse(comand[2]);
                        bus.Drive(distance);
                    }

                }
                else if (vehicickle == "Refuel")
                {
                    string curentVehicicle = comand[1];
                    double fuel = double.Parse(comand[2]);

                    if (curentVehicicle == "Car")
                    {
                        car.Refuel(fuel);
                    }
                    else if (curentVehicicle == "Truck")
                    {
                        car.Refuel(fuel);
                    }
                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:f2}");
        }
    }
}
