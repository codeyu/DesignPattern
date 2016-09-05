namespace DesignPatternLib.AbstractFactory
{
    /// <summary>
    /// The 'ConcreteFactory2' class.
    /// </summary>
    public class America : IContinentFactory
    {
        public IHerbivore CreateHerbivore()
        {
            return new Bison();
        }

        public ICarnivore CreateCarnivore()
        {
            return new Wolf();
        }
    }
}
