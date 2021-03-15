using System;

namespace Garage
{
    public class Ram : Vehicle, IGasVehicle // Gas powered truck
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
            Console.WriteLine($"The {MainColor} Ram goes Babababooombaby!");
        }
    }
}