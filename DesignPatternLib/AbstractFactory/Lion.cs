using System;
namespace DesignPatternLib.AbstractFactory
{
    /// <summary>
    /// The 'ProductB1' class
    /// </summary>
    public class Lion : ICarnivore
    {
        public void Eat(IHerbivore h)
        {
            // Eat Wildebeest
            Console.WriteLine(this.GetType().Name +
                " eats " + h.GetType().Name);
        }
    }
}
