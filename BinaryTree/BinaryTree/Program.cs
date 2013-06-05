using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        static void Add(TreeNode<int> node)
        {
            node.Value = 2 ;
        }

        static void Main(string[] args)
        {

            Tree<int> tree = new Tree<int>();

            tree.AddNode(3);
            tree.AddNode(5);
            tree.AddNode(2);
            tree.AddNode(1);
            tree.AddNode(6);
            tree.AddNode(7);
            tree.AddNode(4);
            tree.AddNode(5);
            tree.AddNode(10);
            tree.AddNode(6);

            //Console.WriteLine(tree.Root);

            //tree.Root.Left = new TreeNode<int>();
            //Add(tree.Root.Left);

            //Console.WriteLine(tree.Root.Left);

            tree.DFS();
            Console.WriteLine();
            tree.BFS();

            Console.WriteLine(tree.Contains(3));          
        }
    }
}
