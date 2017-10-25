namespace DesignPatternLib.Mediator
{
    /// <summary>
    /// The 'Mediator' interface
    /// </summary>
    interface IChatroom
    {
        void Register(Participant participant);
        void Send(string from, string to, string message);
    }
}