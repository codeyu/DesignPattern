using System;
using System.Collections.Generic;

namespace DesignPatternLib.Factory
{
    /// <summary>
    /// Client startup class 
    /// Factory Method Design Pattern.
    /// </summary>
    public class Client
    {
        public static void Test()
        {
            // Document constructors call Factory Method
            var documents = new List<Document> { new Resume(), new Report() };
            // Display document pages
            foreach (var document in documents)
            {
                Console.WriteLine(document + "--");
                foreach (var page in document.Pages)
                {
                    Console.WriteLine(" " + page);
                }
                Console.WriteLine();
            }
            // Wait for user
            Console.ReadKey();
        }
    }
}