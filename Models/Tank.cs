using System;
using Curs11T.Enums;
using Curs11T.Exceptions;

namespace Curs11T.Models
{
    public class Tank
    {
        private FuelType fuelType;
        private double maxCapacity;
        private double currentAmount;

        public Tank(FuelType fuelType, double maxCapacity)
        {
            this.fuelType = fuelType;
            this.maxCapacity = maxCapacity;
            this.currentAmount = 0;
        }

        public void Load(double amount, FuelType type)
        {
            if (type != this.fuelType)
            {
                throw new FuelIncompatibleException("Cisterna este destinata pentru un alt tip de combustibil.");
            }
            if (this.currentAmount + amount > this.maxCapacity)
            {
                throw new CapacityExceededException("Capacitatea maxima a cisternei a fost depasita.");
            }
            this.currentAmount += amount;
        }

        public void Refuel(Vehicle vehicle, double amount)
        {
            if (vehicle.CanBeRefueledWith(this.fuelType))
            {
                if (amount > this.currentAmount)
                {
                    throw new CapacityExceededException("Nu exista suficient combustibil in cisterna.");
                }
                vehicle.Refuel(amount, this.fuelType);
                this.currentAmount -= amount;
            }
            else
            {
                throw new FuelIncompatibleException("Vehiculul nu poate fi alimentat cu acest tip de combustibil.");
            }
        }
    }
}