namespace DesignPatternLib.Template
{
    public class Client
    {
        public static void Test()
        {
            Employee manager = new Manager();
            manager.GetSalary();
            Employee ceo = new CEO();
            ceo.GetSalary();
        }
    }
}