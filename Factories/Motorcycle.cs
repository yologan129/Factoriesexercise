using System;
using System.Collections.Generic;
using System.Text;

namespace Factories
{
    class Motorcycle
    {
        public string Color { get; set; }
        public bool HasHandBrake { get; set; }

        public void Drive()
        {
            Console.WriteLine("Driving a motorcycle");
            //Now we will make our static VehicleFactory class
            //It will contain a static method GetVehicle(), that will return an IVehicle based on the amount of tires it’s given as a parameter
            //Call this functionality in the Main method

        }
    }
}
