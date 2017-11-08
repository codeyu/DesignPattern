using System;

namespace DesignPatternLib.CSharpPracticalPattern.Factory
{
    public class Client
    {
        private IFactory factory;
        public Client(IFactory factory)
        {
            if(factory is null)
            {
                throw new ArgumentNullException(nameof(factory));
            }
            this.factory = factory;
        }
        public IProductWithName GetProduct()
        {
            return factory.Create();
        }
    }
}