using System;

namespace DesignPatternLib.Flyweight
{
    /// <summary>
    /// The 'Flyweight' class
    /// </summary>
    class Character
    {
        protected char symbol;
        protected int width;
        protected int height;
        protected int ascent;
        protected int descent;
        public void Display(int pointSize)
        {
            Console.WriteLine(this.symbol +
                      " (pointsize " + pointSize + ")");
        }
    }
}