using System;

namespace DesignPatternLib.Composite
{
    public class Client
    {
        public static void Test()
        {
            // Build a tree of shapes
            var root = new TreeNode<Shape> { Node = new Shape("Picture") };
            root.Add(new Shape("Red Line"));
            root.Add(new Shape("Blue Circle"));
            root.Add(new Shape("Green Box"));
            var branch = root.Add(new Shape("Two Circles"));
            branch.Add(new Shape("Black Circle"));
            branch.Add(new Shape("White Circle"));
            // Add, remove, and add a shape
            var shape = new Shape("Yellow Line");
            root.Add(shape);
            root.Remove(shape);
            root.Add(shape);
            // Display tree using static method
            TreeNode<Shape>.Display(root, 1);
            Console.ReadKey();
        }
    }
}