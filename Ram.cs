using System;
using System.Globalization;

namespace Garage
{
    public class Ram : Vehicle, IGasVehicle // Gas powered truck
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
            Console.WriteLine($"The {MainColor} Ram goes Babababooombaby!");
        }
    }
}