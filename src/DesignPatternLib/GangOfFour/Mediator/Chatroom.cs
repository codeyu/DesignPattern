using System.Collections.Generic;

namespace DesignPatternLib.Mediator
{
    /// <summary>
    /// The 'ConcreteMediator' class
    /// </summary>
    class Chatroom : IChatroom
    {
        private Dictionary<string, Participant> _participants =
            new Dictionary<string, Participant>();
        public void Register(Participant participant)
        {
            if (!_participants.ContainsKey(participant.Name))
            {
                _participants.Add(participant.Name, participant);
            }
            participant.Chatroom = this;
        }
        public void Send(string from, string to, string message)
        {
            var participant = _participants[to];
            if (participant != null)
            {
                participant.Receive(from, message);
            }
        }
    }
}