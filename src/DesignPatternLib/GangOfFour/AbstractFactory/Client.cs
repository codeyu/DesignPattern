namespace DesignPatternLib.AbstractFactory
{
    public class Client
    {
        public static void Test()
        {
            // Create and run the African animal world
            var africa = new AnimalWorld<Africa>();
            africa.RunFoodChain();

            // Create and run the American animal world
            var america = new AnimalWorld<America>();
            america.RunFoodChain();
        }
    }
}