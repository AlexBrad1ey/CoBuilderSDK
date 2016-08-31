using System;

namespace CoBuilder.Service.Infrastructure.Structures
{
    public class Tree<T>
    {
        public Tree()
        {
            Root = null;
        }

        public Tree(TreeNode<T> root)
        {
            if (root == null) throw new ArgumentNullException(nameof(root));
            Root = root;
        }

        public TreeNode<T> Root { get; protected set; }

        public virtual void Clear()
        {
            Root = null;
        }

        public Tree<T> SubTree(TreeNode<T> root)
        {
            return new Tree<T>(root);
        }
    }
}