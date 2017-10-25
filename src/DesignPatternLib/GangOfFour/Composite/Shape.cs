using System;

namespace DesignPatternLib.Composite
{
    /// <summary>
    /// Shape class
    /// <remarks>
    /// Implements generic IComparable interface
    /// </remarks>
    /// </summary>
    class Shape : IComparable<Shape>
    {
        private string _name;
        // Constructor
        public Shape(string name)
        {
            this._name = name;
        }
        public override string ToString()
        {
            return _name;
        }
        // IComparable<Shape> Member
        public int CompareTo(Shape other)
        {
            return (this == other) ? 0 : -1;
        }
    }
}