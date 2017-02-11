using System;

namespace DesignPatternLib.Memento
{
    public class Client
    {
        public static void Test()
        {
            SalesProspect s = new SalesProspect();
            s.Name = "Noel van Halen";
            s.Phone = "(412) 256-0990";
            s.Budget = 25000.0;
            // Store internal state
            ProspectMemory m = new ProspectMemory();
            m.Memento = s.SaveMemento();
            // Continue changing originator
            s.Name = "Leo Welch";
            s.Phone = "(310) 209-7111";
            s.Budget = 1000000.0;
            // Restore saved state
            s.RestoreMemento(m.Memento);
            // Wait for user
            Console.ReadKey();
        }
    }
}