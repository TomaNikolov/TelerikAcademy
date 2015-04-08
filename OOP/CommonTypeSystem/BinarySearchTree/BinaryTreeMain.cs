namespace BinarySearchTree
{
    using System.Collections.Generic;
    using System.Linq;

    public class BinaryTreeMain
    {
        static void Main()
        {
            BinarySearchTree<int> tree = new BinarySearchTree<int>();
            tree.Add(2);
            tree.Add(3);
            tree.Add(5);
            tree.Add(1);
            tree.Add(6);
            tree.Add(4);
            List<int> test = new List<int>();
            bool contains = tree.Contains(7);
            tree.Delete(5);
            var count = tree.Count();
            foreach (var item in tree)
            {
                System.Console.Write(item + " ");
            }

        }
    }
}
