using System;

namespace DesignPatternLib.Observer
{
    /// <summary>
    /// The 'Subject' abstract class
    /// </summary>
    abstract class Stock
    {
        protected string _symbol;
        protected double _price;
        // Constructor
        public Stock(string symbol, double price)
        {
            this._symbol = symbol;
            this._price = price;
        }
        // Event
        public event EventHandler<ChangeEventArgs> Change;
        // Invoke the Change event
        public virtual void OnChange(ChangeEventArgs e)
        {
            if (Change != null)
            {
                Change(this, e);
            }
        }
        public void Attach(IInvestor investor)
        {
            Change += investor.Update;
        }
        public void Detach(IInvestor investor)
        {
            Change -= investor.Update;
        }
        // Gets or sets the price
        public double Price
        {
            get { return _price; }
            set
            {
                if (_price != value)
                {
                    _price = value;
                    OnChange(new ChangeEventArgs { Symbol = _symbol, Price = _price });
                    Console.WriteLine("");
                }
            }
        }
    }
}