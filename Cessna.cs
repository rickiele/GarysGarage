using System;
using System.Globalization;

namespace Garage
{
    public class Cessna : Vehicle, IGasVehicle
    {
        public double FuelCapacity { get; set; }

        public double CurrentTankPercentage { get; set; }
        public void RefuelTank(double refuel)
        {
            CurrentTankPercentage = 100;
            Console.WriteLine($"The {this.GetType().Name} is refueled to {refuel.ToString("P", CultureInfo.InvariantCulture)}.");
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna goes Krakrakrapeeet!");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Cessna does and barrelroll and stops ded in its tracks.");
        }
    }
}