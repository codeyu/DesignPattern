using System;

namespace DesignPatternLib.Bridge
{
    /// <summary>
    /// The 'RefinedAbstraction' class
    /// </summary>
    class Customers : CustomersBase
    {
        public override void ShowAll()
        {
            // Add separator lines
            Console.WriteLine();
            Console.WriteLine("------------------------");
            base.ShowAll();
            Console.WriteLine("------------------------");
        }
    }
}