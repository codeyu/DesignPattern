using System;
using System.Collections.Generic;

namespace DesignPatternLib.Composite
{
    /// <summary>
    /// Generic tree node class
    /// </summary>
    /// <typeparam name="T">Node type</typeparam>
    class TreeNode<T> where T : IComparable<T>
    {
        private List<TreeNode<T>> _children = new List<TreeNode<T>>();
        // Add a child tree node
        public TreeNode<T> Add(T child)
        {
            var newNode = new TreeNode<T> { Node = child };
            _children.Add(newNode);
            return newNode;
        }
        // Remove a child tree node
        public void Remove(T child)
        {
            foreach (var treeNode in _children)
            {
                if (treeNode.Node.CompareTo(child) == 0)
                {
                    _children.Remove(treeNode);
                    return;
                }
            }
        }
        // Gets or sets the node
        public T Node { get; set; }
        // Gets treenode children
        public List<TreeNode<T>> Children
        {
            get { return _children; }
        }
        // Recursively displays node and its children 
        public static void Display(TreeNode<T> node, int indentation)
        {
            string line = new String('-', indentation);
            Console.WriteLine(line + " " + node.Node);
            node.Children.ForEach(n => Display(n, indentation + 1));
        }
    }
}