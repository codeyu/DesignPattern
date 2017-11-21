namespace DesignPatternLib.CSharpPracticalPattern.AbstractFactory
{
    public interface IProductA
    {
        
    }
    public interface IProductB
    {

    }
    public interface IAbstractFactory
    {
        IProductA CreateProductA();
        IProductB CreateProductB();
    }
}