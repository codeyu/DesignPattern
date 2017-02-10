using System;

namespace DesignPatternLib.Mediator
{
    /// <summary>
    /// A 'ConcreteColleague' class
    /// </summary>
    class NonBeatle : Participant
    {
        public override void Receive(string from, string message)
        {
            Console.Write("To a non-Beatle: ");
            base.Receive(from, message);
        }
    }
}