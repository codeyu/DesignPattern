using System;
using System.Collections.Generic;
namespace DesignPatternLib.Strategy
{
    public interface ISortStrategy
    {
        void Sort(List<Student> list);
    }
}