using System;

namespace Garage
{
    public class Tesla : Vehicle, IElectricVehicle
    {
        public double BatteryKWh { get; set; }
        public string CurrentChargePercentage { get; set; }
        public void ChargeBattery(string charge)
        {
            CurrentChargePercentage = "100%";
            Console.WriteLine($"Vehicle is charged to {charge}.");
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla goes Brubrubrutothemooon!");
        }

    }
}