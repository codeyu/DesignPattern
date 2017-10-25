using System;
using System.Collections.Generic;

namespace DesignPatternLib.Interpreter
{
    public class Client
    {
        public static void Test()
        {
            // Construct the 'parse tree'
            var tree = new List<Expression>
            {
                new ThousandExpression(),
                new HundredExpression(),
                new TenExpression(),
                new OneExpression()
            };
            // Create the context (i.e. roman value)
            string roman = "MCMXXVIII";
            var context = new Context { Input = roman };
            // Interpret
            tree.ForEach(e => e.Interpret(context));
            Console.WriteLine("{0} = {1}", roman, context.Output);
            // Wait for user
            Console.ReadKey();
        }
    }
}