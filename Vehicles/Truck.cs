using Curs11T.Enums;
using Curs11T.Models;

namespace Curs11T.Vehicles
{
    public class Truck
    {
        public DieselCar TractorHead { get; private set; }
        public Tank Tank { get; private set; }

        public Truck(string tractorModel, string tractorId, double tractorTankCapacity, FuelType tankFuelType, double tankCapacity)
        {
            this.TractorHead = new DieselCar(tractorModel, tractorId, tractorTankCapacity);
            this.Tank = new Tank(tankFuelType, tankCapacity);
        }
    }
}