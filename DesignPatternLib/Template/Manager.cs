using System;
namespace DesignPatternLib.Template
{
    public class Manager : Employee
    {
        protected override void GetBasicSalary()
        {
            Console.WriteLine("Get Manager Basic Salary");
        }

        protected override void AddBonus()
        {
            Console.WriteLine("Add Manager Bonus");
        }
    }
}