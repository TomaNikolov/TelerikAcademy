namespace BinarySearchTree
{
    public class TreeNode<T>
    {
        public T Value { get; set; }
        public TreeNode<T> LeftChild { get; set; }
        public TreeNode<T> RightChild { get; set; }

        public TreeNode(T value)
        {
            this.Value = value;
            this.LeftChild = null;
            this.RightChild = null;
        }
    }
}
