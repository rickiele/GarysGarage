using System;

namespace Garage
{
    public class Cessna : Vehicle
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
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