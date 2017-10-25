using System;
using System.Collections.Generic;

namespace DesignPatternLib.Decorator
{
    /// <summary>
    /// The 'ConcreteDecorator' class
    /// </summary>
    class Borrowable<T> : Decorator<T>
    {
        private List<string> _borrowers = new List<string>();
        // Constructor
        public Borrowable(LibraryItem<T> libraryItem)
            : base(libraryItem)
        {
        }
        public void BorrowItem(string name)
        {
            _borrowers.Add(name);
            NumCopies--;
        }
        public void ReturnItem(string name)
        {
            _borrowers.Remove(name);
            NumCopies++;
        }
        public override void Display()
        {
            base.Display();
            _borrowers.ForEach(b =>  Console.WriteLine(" borrower: " + b));
        }
    }
}