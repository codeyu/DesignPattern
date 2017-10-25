using System;

namespace DesignPatternLib.CSharpPracticalPattern.Strategy
{
    public class DescentSortStrategy : IStrategy
    {
        public int PickUp(int[] data)
        {
            Array.Sort<int>(data);
            return data[data.Length - 1];
        }
    }
}