using System;
using System.Collections.Generic;
using System.Text;

namespace Factories
{
    class VehicleFactory
    {
        public car CreateVehicle(string userInput)
        {



            switch (userInput.ToLower())
            {

                case "car":
                    return new car();
                    break;
                case "motorcycle":
                    return new Motorcycle();
                    break;
                default:
                    break;
            }
        }
}
}
