using System;

namespace DesignPatternLib.Mediator
{
    /// <summary>
    /// A 'ConcreteColleague' class
    /// </summary>
    class Beatle : Participant
    {
        public override void Receive(string from, string message)
        {
            Console.Write("To a Beatle: ");
            base.Receive(from, message);
        }
    }
}