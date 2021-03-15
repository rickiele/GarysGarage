using System;


namespace Garage
{

    public class Zero : Vehicle, IElectricVehicle // Electric motorcycle
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
            Console.WriteLine($"The {MainColor} Zero goes Zoooooomie!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Zero did a 360 and turned {direction}.");
        }
    }
}