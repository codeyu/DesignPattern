using System;

namespace DesignPatternLib.Adapter
{
    /// <summary>
    /// The 'Target' class
    /// </summary>
    public class Compound
    {
        protected float _boilingPoint;
        protected float _meltingPoint;
        protected double _molecularWeight;
        protected string _molecularFormula;
        public virtual void Display()
        {
            Console.WriteLine("\nCompound: Unknown ------ ");
        }
    }
}