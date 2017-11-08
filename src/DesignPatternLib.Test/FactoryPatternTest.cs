using System;
using Xunit;
using DesignPatternLib.CSharpPracticalPattern.Factory;

namespace DesignPatternLib.Test
{
    public  class FactoryPatternTest
    {
        [Fact]
        public void CSharpPracticalPattern_SimpleFactory_Test()
        {
            SimpleFactory  factory = new SimpleFactory();
            IProduct product = factory.Create();
            Assert.Equal(typeof(ConcreteProductA), product.GetType());
        }
        [Fact]
        public void CSharpPracticalPattern_FactoryMethod_Test()
        {
            IFactory factory = (new Assembler()).Create<IFactory>();
            Client client = new Client(factory);
            IProductWithName product = client.GetProduct();
            Assert.Equal("C", product.Name);
        }
    }
}