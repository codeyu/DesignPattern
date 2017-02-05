using System;

namespace DesignPatternLib.Decorator
{
    /// <summary>
    /// The 'ConcreteComponent' class
    /// </summary>
    class Book : LibraryItem<Book>
    {
        private string _author;
        private string _title;
        // Constructor
        public Book(string author, string title, int numCopies)
        {
            this._author = author;
            this._title = title;
            NumCopies = numCopies;
        }
        public override void Display()
        {
            Console.WriteLine("\nBook ------ ");
            Console.WriteLine(" Author: {0}", _author);
            Console.WriteLine(" Title: {0}", _title);
            Console.WriteLine(" # Copies: {0}", NumCopies);
        }
    }
}