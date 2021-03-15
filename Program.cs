using System;

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
            Zero fxs = new Zero()
            {
                MainColor = "Orange"
            };


            Tesla modelS = new Tesla()
            {
                MainColor = "Black"
            };

            Cessna mx410 = new Cessna()
            {
                MainColor = "Plurple"
            };

            Ram bigTruck = new Ram()
            {
                MainColor = "Blooberry Blue"
            };

            fxs.Drive();
            fxs.Turn("left");
            modelS.Drive();
            mx410.Drive();
            mx410.Turn("right");
            mx410.Stop();
            bigTruck.Drive();
        }
    }
}
