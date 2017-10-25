using System;

namespace DesignPatternLib.CSharpPracticalPattern.Strategy
{
    public class Context : IContext
    {
        public IStrategy Strategy { get; set; }
        public int GetData(int[] data)
        {
            if(Strategy == null) throw new NullReferenceException(nameof(Strategy));
            if(data == null) throw  new ArgumentException(nameof(data));
            return Strategy.PickUp(data);
        }
    }
}