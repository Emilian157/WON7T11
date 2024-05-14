using Curs11T.Enums;
using Curs11T.Exceptions;

namespace Curs11T.Models
{
    public class DieselCar : Vehicle
    {
        public DieselCar(string model, string id, double tankCapacity)
            : base(model, id, tankCapacity) { }

        public override bool CanBeRefueledWith(FuelType type)
        {
            return type == FuelType.Diesel;
        }

        public override void Refuel(double amount, FuelType type)
        {
            if (type != FuelType.Diesel)
            {
                throw new FuelIncompatibleException("Vehiculul diesel nu poate fi alimentat cu acest tip de combustibil.");
            }
            if (this.CurrentFuel + amount > this.TankCapacity)
            {
                throw new CapacityExceededException("Capacitatea maxima a rezervorului a fost depasita.");
            }
            this.CurrentFuel += amount;
        }
    }
}