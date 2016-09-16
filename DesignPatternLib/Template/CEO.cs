using System;
namespace DesignPatternLib.Template
{
    public class CEO : Employee
    {
        protected override  void GetBasicSalary()
        {
            Console.WriteLine("Get CEO Basic Salary");
        }

        protected override void AddBonus()
        {
            Console.WriteLine("Add CEO Bonus");
        }
    }
}

