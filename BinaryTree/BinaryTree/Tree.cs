using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class Tree<T> where T : IComparable<T>
    {
        private TreeNode<T> root = new TreeNode<T>();

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

            if (root.Value.CompareTo(value) > 0)
            {
                TreeNode<T> current = new TreeNode<T>(value);
                this.AddNode(current, root.Left);
            }
            else
            {
                TreeNode<T> current = new TreeNode<T>(value);
                this.AddNode(current, root.Right);
            }           
        }

        private void AddNode(TreeNode<T> addedNode, TreeNode<T> currentNode)
        {
            if (currentNode == null)
            {
                currentNode = new TreeNode<T>(addedNode.Value);
                return;
            }

            if (currentNode.Value.CompareTo(addedNode.Value) <= 0)
            {
                this.AddNode(new TreeNode<T>(addedNode.Value), currentNode.Left);
            }
            else
            {
                this.AddNode(new TreeNode<T>(addedNode.Value), currentNode.Right);
            }  
        }
    }
}
