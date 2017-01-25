using System;
using System.Collections.Generic;
namespace DesignPatternLib.Strategy
{
    /// <summary>
    /// A 'ConcreteStrategy' class
    /// </summary>
    public class ShellSort : ISortStrategy
    {
        public void Sort(List<Student> list)
        {
            // ShellSort();  not-implemented
            Console.WriteLine("ShellSorted list ");
        }
    }
}