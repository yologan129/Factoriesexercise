using System;

namespace Factories
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what type of vehicle do you want to make? Car or Motorcycle?");
            string userInput = Console.ReadLine();

            VehicleFactory factory = new VehicleFactory();
             Car myCar = factory.CreateVehicle(userInput);

            Console.WriteLine("Lets make another vehicle");
            userInput = Console.ReadLine();

        }
    }
}
