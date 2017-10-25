using System;

namespace DesignPatternLib.Observer
{
    /// <summary>
    /// The 'ConcreteObserver' class
    /// </summary>
    class Investor : IInvestor
    {
        // Gets or sets the investor name
        public string Name { get; set; }
        // Gets or sets the stock
        public Stock Stock { get; set; }
        public void Update(object sender, ChangeEventArgs e)
        {
            Console.WriteLine("Notified {0} of {1}'s " +
                "change to {2:C}", Name, e.Symbol, e.Price);
        }
    }
}