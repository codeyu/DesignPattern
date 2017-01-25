using System;
using System.Collections.Generic;
namespace DesignPatternLib.Strategy
{
    /// <summary>
    /// A 'ConcreteStrategy' class
    /// </summary>
    public class MergeSort : ISortStrategy
    {
        public void Sort(List<Student> list)
        {
            // MergeSort(); not-implemented
            Console.WriteLine("MergeSorted list ");
        }
    }
}