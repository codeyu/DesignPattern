using System;
using Xunit;
using DesignPatternLib.Proxy;
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
    }
}