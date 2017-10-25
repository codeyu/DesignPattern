using System;

namespace DesignPatternLib.Command
{
    public class Client
    {
        public static void Test()
        {
            // Create user and let her compute
            var user = new User();
            // Issue several compute commands
            user.Compute('+', 100);
            user.Compute('-', 50);
            user.Compute('*', 10);
            user.Compute('/', 2);
            // Undo 4 commands
            user.Undo(4);
            // Redo 3 commands
            user.Redo(3);
            // Wait for user
            Console.ReadKey();
        }
    }
}