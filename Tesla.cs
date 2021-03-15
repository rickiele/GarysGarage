using System;
using System.Globalization;

namespace Garage
{
    public class Tesla : Vehicle, IElectricVehicle
    {
        public double BatteryKWh { get; set; }
        public int CurrentChargePercentage { get; set; }
        public void ChargeBattery(int charge)
        {
            CurrentChargePercentage = 100;
            CurrentChargePercentage.ToString("P", CultureInfo.InvariantCulture);
            Console.WriteLine($"The {this.GetType().Name} is refueled to {charge.ToString("P", CultureInfo.InvariantCulture)}.");
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla goes Brubrubrutothemooon!");
        }

    }
}