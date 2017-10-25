namespace DesignPatternLib.Command
{
    /// <summary>
    /// The 'Command' interface
    /// </summary>
    interface ICommand
    {
        void Execute();
        void UnExecute();
    }

}