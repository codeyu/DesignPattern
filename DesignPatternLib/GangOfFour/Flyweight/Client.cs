using System;

namespace DesignPatternLib.Flyweight
{
    public class Client
    {
        public static void Test()
        {
            // Build a document with text
            string document = "AAZZBBZB";
            char[] chars = document.ToCharArray();
            var factory = new CharacterFactory();
            // extrinsic state
            int pointSize = 10;
            // For each character use a flyweight object
            foreach (char c in chars)
            {
                var character = factory[c];
                character.Display(++pointSize);
            }
            // Wait for user
            Console.ReadKey();
        }
    }
}