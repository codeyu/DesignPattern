namespace DesignPatternLib.Decorator
{
    /// <summary>
    /// The 'Decorator' abstract class
    /// </summary>
    abstract class Decorator<T> : LibraryItem<T>
    {
        private LibraryItem<T> _libraryItem;
        // Constructor
        public Decorator(LibraryItem<T> libraryItem)
        {
            _libraryItem = libraryItem;
        }
        public override void Display()
        {
            _libraryItem.Display();
        }
    }
}