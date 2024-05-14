using System;
using Curs11T.Models;
using Curs11T.Vehicles;
using Curs11T.Enums;
using Curs11T.Exceptions;

namespace Curs11T
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Initializam cisternele
                Tank gasolineTank = new Tank(FuelType.Gasoline, 10000);
                Tank electricityTank = new Tank(FuelType.Electricity, 10000);
                Tank gplTank = new Tank(FuelType.GPL, 10000);

                // Incarcam cisternele
                gasolineTank.Load(5000, FuelType.Gasoline);
                electricityTank.Load(7000, FuelType.Electricity);
                gplTank.Load(7000, FuelType.GPL);

                // Initializam vehiculele
                GasolineCar gasolineCar = new GasolineCar("Audi A4", "ID123", 60);
                DieselCar dieselCar = new DieselCar("VW Passat", "ID456", 70);
                GPLCar gplCar = new GPLCar("Dacia Logan", "ID789", 50);
                PlugInHybridCar hybridCar = new PlugInHybridCar("Toyota Prius", "ID101", 45);

                // Alimentam vehiculele
                gasolineTank.Refuel(gasolineCar, 50);
                Console.WriteLine(gasolineCar.GetDescription());

                gasolineTank.Refuel(hybridCar, 30);
                electricityTank.Refuel(hybridCar, 10);
                Console.WriteLine(hybridCar.GetDescription());

                gplTank.Refuel(gplCar, 30);
                Console.WriteLine(gplCar.GetDescription());

                // Initializam camionul
                Truck truck = new Truck("Mercedes Actros", "TRUCK001", 300, FuelType.Diesel, 5000);

                // Alimentam capul tractor al camionului
                truck.Tank.Load(2000, FuelType.Diesel);
                truck.Tank.Refuel(truck.TractorHead, 100);
                Console.WriteLine(truck.TractorHead.GetDescription());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Eroare: {ex.Message}");
            }
        }
    }
}