using System;
using Xunit;
using DesignPatternLib.Proxy;
namespace DesignPatternLib.Test
{
    public class ProxyPatternTest
    {
        [Fact]
        public void GangOfFour_Proxy_Test()
        {
            MathProxy proxy = new MathProxy();
            Assert.Equal(2, proxy.Add(1,1));
        }
    }
}
