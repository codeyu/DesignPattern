using System.Collections.Generic;

namespace DesignPatternLib.Factory
{
    /// <summary>
    /// The 'Creator' abstract class
    /// </summary>
    abstract class Document
    {
        // Constructor invokes Factory Method
        public Document()
        {
            this.CreatePages();
        }
        // Gets list of document pages
        public List<Page> Pages { get; protected set; }
        // Factory Method
        public abstract void CreatePages();
        // Override
        public override string ToString()
        {
            return nameof(Document);
        }
    }
}