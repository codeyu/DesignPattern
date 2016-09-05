using System;
using DesignPatternLib.AbstractFactory;
namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create and run the African animal world
            var africa = new AnimalWorld<Africa>();
            africa.RunFoodChain();

            // Create and run the American animal world
            var america = new AnimalWorld<America>();
            america.RunFoodChain();

            // Wait for user input
            Console.ReadKey();
        }
    }
}
