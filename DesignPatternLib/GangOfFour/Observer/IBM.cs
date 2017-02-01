namespace DesignPatternLib.Observer
{
    /// <summary>
    /// The 'ConcreteSubject' class
    /// </summary>
    class IBM : Stock
    {
        // Constructor - symbol for IBM is always same
        public IBM(double price)
            : base("IBM", price)
        {
        }
    }
}