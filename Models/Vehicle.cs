using System;
using Curs11T.Enums;
using Curs11T.Exceptions;

namespace Curs11T.Models
{
    public abstract class Vehicle
    {
        public string Model { get; set; }
        public string Id { get; set; }
        public double TankCapacity { get; set; }
        public double CurrentFuel { get; set; }

        public Vehicle(string model, string id, double tankCapacity)
        {
            this.Model = model;
            this.Id = id;
            this.TankCapacity = tankCapacity;
            this.CurrentFuel = 0;
        }

        public abstract bool CanBeRefueledWith(FuelType type);

        public abstract void Refuel(double amount, FuelType type);

        public virtual string GetDescription()
        {
            return $"Model: {Model}, ID: {Id}, Capacitate Rezervor: {TankCapacity}, Combustibil Curent: {CurrentFuel}";
        }
    }
}