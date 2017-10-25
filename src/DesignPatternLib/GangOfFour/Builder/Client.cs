using System;

namespace DesignPatternLib.Builder
{
    public class Client
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        public static void Test()
        {
            // Create shop
            var shop = new Shop();
            // Construct and display vehicles
            shop.Construct(new ScooterBuilder());
            shop.ShowVehicle();
            shop.Construct(new CarBuilder());
            shop.ShowVehicle();
            shop.Construct(new MotorCycleBuilder());
            shop.ShowVehicle();
            // Wait for user
            Console.ReadKey();
        }
    }
}