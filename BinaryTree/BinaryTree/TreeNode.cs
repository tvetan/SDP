namespace BinaryTree
{
    public class TreeNode<T>
    {
        private T value;

        private TreeNode<T> left;

        private TreeNode<T> right;

        private TreeNode<T> parent;

        public TreeNode()
        {
        }

        public TreeNode(T value)
        {
            this.Value = value;
        }

        public override string ToString()
        {
            return string.Format("{0}", this.Value );
        }

        public TreeNode<T> Parent
        {
            get
            {
                return this.parent;
            }
            set
            {
                this.parent = value;
            }
        }

        public TreeNode<T> Right
        {
            get
            {
                return this.right;
            }
            set
            {
                this.right = value;
            }
        }

        public TreeNode<T> Left
        {
            get
            {
                return this.left;
            }
            set
            {
                this.left = value;
            }
        }

        public T Value
        {
            get
            {
                return this.value;
            }
            set
            {
                this.value = value;
            }
        }
    }
}
