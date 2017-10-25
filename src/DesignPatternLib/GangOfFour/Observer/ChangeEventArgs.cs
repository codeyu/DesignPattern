using System;

namespace DesignPatternLib.Observer
{
    // Custom event arguments
    public class ChangeEventArgs : EventArgs
    {
        // Gets or sets symbol
        public string Symbol { get; set; }
        // Gets or sets price
        public double Price { get; set; }
    }
}