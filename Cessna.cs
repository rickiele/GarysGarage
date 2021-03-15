using System;

namespace Garage
{
    public class Cessna : Vehicle, IGasVehicle
    {
        public double FuelCapacity { get; set; }

        public double CurrentTankPercentage { get; set; }
        public void RefuelTank(double refuel)
        {
            CurrentTankPercentage = 100.00;
            Console.WriteLine($"Vehicle is refueled to {refuel}.");
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