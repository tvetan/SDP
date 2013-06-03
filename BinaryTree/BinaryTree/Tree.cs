using System;
using System.Collections.Generic;

namespace BinaryTree
{
    public class Tree<T> where T : IComparable<T>
    {
        private TreeNode<T> root;

        public Tree()
        {
        }

        public Tree(T rootValue)
        {
            root.Value = rootValue;
        }

        public TreeNode<T> Root
        {
            get
            {
                return this.root;
            }
            set
            {
                this.root = value;
            }
        }

        public void AddNode(T value)
        {
            if (root == null)
            {
                root = new TreeNode<T>(value);
                return;
            }

            this.AddNode(this.root, value);
        }

        private void AddNode(TreeNode<T> node, T value)
        { 
            if (value.CompareTo(node.Value) < 0)
            {
                if (node.Left == null)
                {
                    node.AddLeftNode(value);
                }
                else
                {
                    this.AddNode(node.Left, value);
                }
            }
            else 
            {
                if (node.Right == null)
                {
                    node.AddRightNode(value);
                }
                else
                {
                    this.AddNode(node.Right, value);
                }
            }
        }

        public void DFS()
        {
            DFS(root);
        }

        private void DFS(TreeNode<T> currentNode)
        {
            if (currentNode == null)
            {
                return;
            }
            Console.WriteLine(currentNode);

            DFS(currentNode.Left);
            DFS(currentNode.Right);
        }

        public void BFS()
        {
            Queue<TreeNode<T>> queue = new Queue<TreeNode<T>>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                var currentNode = queue.Dequeue();

                Console.WriteLine(currentNode);
                if (currentNode.Left != null)
                {
                    queue.Enqueue(currentNode.Left);
                }
                if (currentNode.Right != null)
                {
                    queue.Enqueue(currentNode.Right);
                }
               
            }
        }

        public bool Contains(T value)
        {
            return Contains(value, root);
        }

        private bool Contains(T value, TreeNode<T> currentNode)
        {
            if (currentNode == null)
            {
                return false;
            }
            else if (currentNode.Value.CompareTo(value) == 0)
            {
                return true;
            }
            else if (currentNode.Value.CompareTo(value) < 0)
            {
              return  Contains(value, currentNode.Right);
            }
            else
            {
              return  Contains(value, currentNode.Left);
            }
        }
    }
}