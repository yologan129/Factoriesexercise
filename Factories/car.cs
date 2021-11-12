using System;
using System.Collections.Generic;
using System.Text;

namespace Factories
{
    class car : IVehicle
    {
        public string Color { get; set; }
        public bool IsDrivable { get; set; }

        public void Drive()
        {
            Console.WriteLine("Sorry can't text I'm driving my {color} car");
        }
    }
}
