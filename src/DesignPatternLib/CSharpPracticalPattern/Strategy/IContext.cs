namespace DesignPatternLib.CSharpPracticalPattern.Strategy
{
    public interface IContext
    {
        IStrategy Strategy{get;set;}
        int GetData(int[] data);
    }
}