using System;

namespace DesignPatternLib.Facade
{
    /// <summary>
    /// MainApp startup class for .NET optimized 
    /// Facade Design Pattern.
    /// </summary>
    public class Client
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        public static void Test()
        {
            // Facade
            var mortgage = new Mortgage();
            // Evaluate mortgage eligibility for customer
            var customer = new Customer { Name = "Ann McKinsey" };
            bool eligible = mortgage.IsEligible(customer, 125000);
            Console.WriteLine("\n" + customer.Name +
                " has been " + (eligible ? "Approved" : "Rejected"));
            // Wait for user
            Console.ReadKey();
        }
    }
}