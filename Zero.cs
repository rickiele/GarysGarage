using System;
using System.Globalization;

namespace Garage
{

    public class Zero : Vehicle, IElectricVehicle // Electric motorcycle
    {
        public double BatteryKWh { get; set; }
        public int CurrentChargePercentage { get; set; }

        public void ChargeBattery(int charge)
        {
            CurrentChargePercentage = 100;
            Console.WriteLine($"The {this.GetType().Name} is refueled to {charge.ToString("P", CultureInfo.InvariantCulture)}");
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero goes Zoooooomie!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Zero did a 360 and turned {direction}.");
        }
    }
}