namespace DesignPatternLib.AbstractFactory
{
    /// <summary>
    /// The 'ConcreteFactory1' class.
    /// </summary>
    public class Africa : IContinentFactory
    {
        public IHerbivore CreateHerbivore()
        {
            return new Wildebeest();
        }

        public ICarnivore CreateCarnivore()
        {
            return new Lion();
        }
    }
}
