using System;
using System.Collections.Generic;

namespace Garage
{
    public interface IElectricVehicle
    {
        // Don't need to declare public because all are public by default in Interface
        string CurrentChargePercentage { get; set; }
        void ChargeBattery(string charge);
    }
}