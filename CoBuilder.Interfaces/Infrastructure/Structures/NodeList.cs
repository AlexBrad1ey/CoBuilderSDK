using System.Collections.ObjectModel;
using System.Linq;

namespace CoBuilder.Service.Infrastructure.Structures
{
    public class NodeList<T> : Collection<TreeNode<T>>
    {
        public NodeList()
        {
        }

        public NodeList(int initialSize)
        {
            // Add the specified number of items
            for (var i = 0; i < initialSize; i++)
                Items.Add(default(TreeNode<T>));
        }

        public TreeNode<T> FindByValue(T value)
        {
            // search the list for the value
            return Items.FirstOrDefault(node => node.Value.Equals(value));
        }
    }
}