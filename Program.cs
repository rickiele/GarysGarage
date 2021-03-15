using System;
using System.Collections.Generic;

namespace Garage
{
    class Program
    {
        /*
        Class based inheritance let's you specify that one type will contain all of the 
        properties and methods that are defined in another type, without having to duplicate the 
        code in the two source code files. 

        You will use inheritance to reduce the amount of duplicated code that can 
        arise in a system with dozens of types that all share the exact same 
        properties and/or methods.

        You will likely be asked about inheritance during the interview process 
        and should be able to describe it in one of the following ways.

        1. Allows one type to include all of the public properties and methods of another type.
        2. It reduces duplicated code when many types in a program all have the same properties 
           and methods.


        
        */

        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            Zero fx = new Zero();
            Tesla modelS = new Tesla();

            fx.CurrentChargePercentage = "20%";
            fxs.CurrentChargePercentage = "60%";
            modelS.CurrentChargePercentage = "10%";


            List<IElectricVehicle> electricVehicles = new List<IElectricVehicle>() {
                fx, fxs, modelS
              };

            Console.WriteLine("--Electric Vehicles Current - Charge");
            foreach (IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            Console.WriteLine("--Electric Vehicles - Charge battery to 100%");
            foreach (IElectricVehicle ev in electricVehicles)
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery("100");
            }

            Console.WriteLine("--Vehicles after charge.");
            foreach (IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            /***********************************************/
            Console.WriteLine("\n");

            Ram ram = new Ram();
            Cessna cessna150 = new Cessna();

            List<IGasVehicle> gasVehicles = new List<IGasVehicle>() {
                ram, cessna150
              };

            Console.WriteLine("--Gas Vehicles - Before Refuel");
            foreach (IGasVehicle gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }

            Console.WriteLine("--Gas Vehicles - Being Refueled");
            foreach (IGasVehicle gv in gasVehicles)
            {
                // This should completely refuel the gas tank
                gv.RefuelTank(100.00);
            }

            Console.WriteLine("--Gas Vehicles - After Refuel");
            foreach (IGasVehicle gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }
        }
    }
}
