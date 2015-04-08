namespace BinarySearchTree
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class BinarySearchTree<T> : IEnumerable<T>
        where T : IComparable
    {
        private TreeNode<T> root;
        public BinarySearchTree()
        {
            this.root = null;
        }

        public override bool Equals(object obj)
        {
            var otherTree = (obj as BinarySearchTree<T>);
            if (this == otherTree)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public void Add(T element)
        {
            TreeNode<T> newNode = new TreeNode<T>(element);
            if (this.root != null)
            {
                this.InsertNode(this.root, newNode);
            }
            else
            {
                this.root = newNode;
            }
        }

        public void Delete(T element)
        {
            if (this.root != null)
            {
                TreeNode<T> newNode = new TreeNode<T>(element);
                this.root = RemoveElement(this.root, newNode);
            }
           
        }

        public bool Contains(T element)
        {
            if (this.root != null)
            {
                TreeNode<T> newNode = new TreeNode<T>(element);
                return SearchForNode(this.root, newNode);
            }
            else
            {
                return false;
            }
        }

        private static TreeNode<T> RemoveElement(TreeNode<T> root, TreeNode<T> newNode)
        {
            TreeNode<T> tempNode = root;

            int result = newNode.Value.CompareTo(tempNode.Value);
            if (result == 0)
            {
                if (tempNode.LeftChild == null && tempNode.RightChild == null)
                {
                    tempNode = null;
                }
                else if (tempNode.LeftChild == null)
                {
                    tempNode = tempNode.RightChild;
                }
                else if (tempNode.RightChild == null)
                {
                    tempNode = tempNode.LeftChild;
                }
                else
                {
                    var nodeValue = GetMostLeftChild(tempNode.RightChild);
                    tempNode.Value = nodeValue.Value;
                    tempNode.RightChild = RemoveElement(tempNode.RightChild, nodeValue);

                }
                return tempNode;
            }
            else if (result < 0)
            {

                if (tempNode.LeftChild == null)
                {
                    return null;
                }

                else
                {
                    tempNode.LeftChild = RemoveElement(tempNode.LeftChild, newNode);
                    return tempNode;
                }
            }
            else
            {
                if (tempNode.RightChild == null)
                {
                    return null;
                }
                else
                {
                    tempNode.RightChild = RemoveElement(tempNode.RightChild, newNode);
                    return tempNode;
                }
            }
        }

        private static TreeNode<T> GetMostLeftChild(TreeNode<T> root)
        {
            TreeNode<T> tempNode = root;
            if (tempNode.LeftChild == null)
            {
                return tempNode;
            }
            else
            {
                tempNode = GetMostLeftChild(tempNode.LeftChild);
                return tempNode;
            }
        }
        private bool SearchForNode(TreeNode<T> root, TreeNode<T> newNode)
        {
            TreeNode<T> tempNode = root;

            int result = newNode.Value.CompareTo(tempNode.Value);
            if (result == 0)
            {
                return true;
            }
            if (result < 0)
            {

                if (tempNode.LeftChild == null)
                {
                    return false;
                }

                else
                {
                    tempNode = tempNode.LeftChild;
                    return SearchForNode(tempNode, newNode);
                }
            }
            else
            {
                if (tempNode.RightChild == null)
                {
                    return false;
                }
                else
                {
                    tempNode = tempNode.RightChild;
                    return SearchForNode(tempNode, newNode);
                }
            }
        }

        private void InsertNode(TreeNode<T> root, TreeNode<T> newNode)
        {
            TreeNode<T> tempNode = root;

            int result = newNode.Value.CompareTo(tempNode.Value);
            if (result <= 0)
            {
                if (tempNode.LeftChild == null)
                {
                    tempNode.LeftChild = newNode;
                }
                else
                {
                    tempNode = tempNode.LeftChild;
                    InsertNode(tempNode, newNode);
                }
            }
            else
            {
                if (tempNode.RightChild == null)
                {
                    tempNode.RightChild = newNode;
                }
                else
                {
                    tempNode = tempNode.RightChild;
                    InsertNode(tempNode, newNode);
                }
            }
        }

        //Implement IEnumerable<T> to traverse the tree.
        //using BFS 
        public IEnumerator<T> GetEnumerator()
        {

            var bfs = new Queue<TreeNode<T>>();
            if (this.root != null)
            {
                bfs.Enqueue(this.root);
            }
            while (bfs.Count != 0)
            {
                var result = bfs.Dequeue();
                if (result.LeftChild != null) bfs.Enqueue(result.LeftChild);
                if (result.RightChild != null) bfs.Enqueue(result.RightChild);
                yield return result.Value;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
