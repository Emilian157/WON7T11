using Curs11T.Enums;
using Curs11T.Exceptions;

namespace Curs11T.Models
{
    public class GPLCar : Vehicle
    {
        public GPLCar(string model, string id, double tankCapacity)
            : base(model, id, tankCapacity) { }

        public override bool CanBeRefueledWith(FuelType type)
        {
            return type == FuelType.Gasoline || type == FuelType.GPL;
        }

        public override void Refuel(double amount, FuelType type)
        {
            if (type != FuelType.Gasoline && type != FuelType.GPL)
            {
                throw new FuelIncompatibleException("Vehiculul GPL nu poate fi alimentat cu acest tip de combustibil.");
            }
            if (this.CurrentFuel + amount > this.TankCapacity)
            {
                throw new CapacityExceededException("Capacitatea maxima a rezervorului a fost depasita.");
            }
            this.CurrentFuel += amount;
        }
    }
}