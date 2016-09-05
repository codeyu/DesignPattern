using System;
namespace DesignPatternLib.AbstractFactory
{
    /// <summary>
    /// The 'ProductB2' class
    /// </summary>
    public class Wolf : ICarnivore
    {
        public void Eat(IHerbivore h)
        {
            // Eat Bison
            Console.WriteLine(this.GetType().Name +
                " eats " + h.GetType().Name);
        }
    }
}
