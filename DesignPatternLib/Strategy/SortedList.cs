using System;
using System.Collections.Generic;
namespace DesignPatternLib.Strategy
{
    /// <summary>
    /// The 'Context' class
    /// </summary>
    public class SortedList : List<Student>
    {
        // Sets sort strategy
        public ISortStrategy SortStrategy { get; set; }

        // Perform sort
        public void SortStudents()
        {
            SortStrategy.Sort(this);

            // Display sort results
            foreach (var student in this)
            {
                Console.WriteLine(" " + student.Name);
            }
            Console.WriteLine();
        }
    }
}