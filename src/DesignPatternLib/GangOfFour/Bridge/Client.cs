using System;

namespace DesignPatternLib.Bridge
{
    public class Client
    {
        public static void Test()
        {
            // Create RefinedAbstraction
            var customers = new Customers();
            // Set ConcreteImplementor
            customers.DataObject = new CustomersData { City = "Chicago" } ;
            // Exercise the bridge
            customers.Show();
            customers.Next();
            customers.Show();
            customers.Next();
            customers.Show();
            customers.Add("Henry Velasquez");
            customers.ShowAll();
            // Wait for user
            Console.ReadKey();
        }
    }
}