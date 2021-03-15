using System;


namespace Garage
{

    public class Zero : Vehicle // Electric motorcycle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
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