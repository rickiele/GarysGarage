using System;

namespace Garage
{
    public interface IGasVehicle
    {
        double FuelCapacity { get; set; }

        double CurrentTankPercentage { get; set; }
        void RefuelTank(double refuel)
        {

        }
    }
}