namespace DesignPatternLib.CSharpPracticalPattern.Factory
{
    public interface IProductWithName
    {
        string Name {get;}
    }
    public class ProductC : IProductWithName
    {
        public string Name => "C";
    }
    public class ProductD : IProductWithName
    {
        public string Name => "D";
    }

    public interface IFactory
    {
        IProductWithName Create();
    }
    public class FactoryC : IFactory
    {
        public IProductWithName Create()
        {
            return new ProductC();
        }
    }
    public class FactoryD : IFactory
    {
        public IProductWithName Create()
        {
            return new ProductD();
        }
    }
}