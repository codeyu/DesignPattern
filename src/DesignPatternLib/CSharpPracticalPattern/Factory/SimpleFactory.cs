namespace DesignPatternLib.CSharpPracticalPattern.Factory
{
    public interface IProduct{}
    public class ConcreteProductA : IProduct{}
    public class ConcreteProductB : IProduct{}
    public class SimpleFactory
    {
        public IProduct Create()
        {
            return new ConcreteProductA();
        }
    }
}