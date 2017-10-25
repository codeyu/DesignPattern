using System;

namespace DesignPatternLib.CSharpPracticalPattern.Strategy
{
    public class AscentSortStrategy : IStrategy
    {
        public int PickUp(int[] data)
        {
            Array.Sort<int>(data);
            return data[0];
        }
    }
}