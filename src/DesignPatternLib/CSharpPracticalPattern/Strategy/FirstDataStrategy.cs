namespace DesignPatternLib.CSharpPracticalPattern.Strategy
{
    public class FirstDataStrategy : IStrategy
    {
        public int PickUp(int[] data)
        {
            return data[0];
        }
    }
}