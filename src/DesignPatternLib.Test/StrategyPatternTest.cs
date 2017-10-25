using DesignPatternLib.CSharpPracticalPattern.Strategy;
using Xunit;

namespace DesignPatternLib.Test
{
    public class StrategyPatternTest
    {
        [Fact]
        public void CSharpPracticalPattern_Strategy_Test()
        {
            var data = new[] {3, 5, 7, 9, 1};
            IContext context = new Context();
            context.Strategy = new AscentSortStrategy();
            Assert.Equal(1,context.GetData(data));
            data = new[] {3, 5, 7, 9, 1};
            context.Strategy = new DescentSortStrategy();
            Assert.Equal(9,context.GetData(data));
            data = new[] {3, 5, 7, 9, 1};
            context.Strategy = new FirstDataStrategy();
            Assert.Equal(3,context.GetData(data));
        }
    }
}